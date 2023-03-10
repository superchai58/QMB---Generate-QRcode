using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_GenBarcode
{
    public partial class Form1 : Form
    {
        DialogResult result = new DialogResult();
        IOException ex = new IOException();
        DataTable dt = new DataTable();
        int flage = 0, flageChk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //--setting default--
            lbFileName.Text = "";
            SetManualEvent();         
        }

        public void SetManualEvent()
        {
           // rdoManual.Select();
            lbText.Text = "Manual";
            txtManual.Text = "";
            txtManual.Visible = true;
            txtManual.Focus();
            btnUploadExcel.Visible = false;
            pcbBarCode.Image = null;
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            SetManualEvent();
        }

        private void rdoUploadExcel_CheckedChanged(object sender, EventArgs e)
        {
            SetUploadFileEvent();
        }

        public void SetUploadFileEvent()
        {
            //rdoUploadExcel.Select();
            lbText.Text = "Upload";
            txtManual.Text = "";
            lbFileName.Text = "";
            txtManual.Visible = false;
            btnUploadExcel.Visible = true;
            pcbBarCode.Image = null;
            result = DialogResult.No;
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {            
            if (rdoManual.Checked == true)
            {
                //--Check text--
                if (txtManual.Text.Trim() != "")
                {
                    if (!bgwUoloadManual.IsBusy)
                    {
                        pcbLoad.Visible = true;
                        bgwUoloadManual.RunWorkerAsync();
                    }
                }
                else
                {
                    playNG();
                    MessageBox.Show("You have not filled in the information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    SetManualEvent();
                }
            }
            else
            {
                if (!bgwUploadFile.IsBusy)
                {
                    flage = 0;
                    pcbLoad.Visible = true;
                    int size = -1;                    

                    bgwUploadFile.RunWorkerAsync();
                }
            }
        }

        private void bgwUoloadManual_DoWork(object sender, DoWorkEventArgs e)
        {
            //--get barcode from txt--
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;            
            pcbBarCode.Image = qrCode.Draw(txtManual.Text.Trim(), 50);

            //--Save file to PDF--
            pcbBarCode.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\CS_QRCode" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_0.png", ImageFormat.Png);
        }

        private void bgwUoloadManual_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            playOK();
            MessageBox.Show("Save to " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\CS_QRCode__.png finished", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void bgwUploadFile_DoWork(object sender, DoWorkEventArgs e)
        {
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofdExcel.FileName;
                try
                {
                    dt = ReadExcelFile(file, "Sheet1", "*", "dt", true);
                    flage = 0; //Check have data
                }
                catch (IOException ex1)
                {
                    ex = ex1;
                    flage = 1; //Check not have data
                }
            }

            //--save image--
            if (dt.Rows.Count > 0)
            {
                int i = 0;          
                foreach (DataRow row in dt.Rows)
                {                    
                    //--get barcode from txt--
                    Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    PictureBox tmpPic = new PictureBox();
                    tmpPic.Image = qrCode.Draw(row["SN"].ToString().Trim(), 50);

                    //--Save file to PDF--
                    tmpPic.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\CS_QRCode" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + i + ".png", ImageFormat.Png);
                    i += 1;

                    pcbBarCode.Image = tmpPic.Image;
                }
            }                      
        }

        private void bgwUploadFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (dt.Rows.Count > 0)
            {
                //--Show message in label--                                        
                playOK();
                MessageBox.Show("Save to " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\downloads\\CS_QRCode__.png finished", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                SetUploadFileEvent();
            }
            else
            {                
                playNG();
                MessageBox.Show("File type not .xlsx or .xls or file not have data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                SetUploadFileEvent();
            }
            dt.Rows.Clear();
        }

        public static DataTable ReadExcelFile(String filePath,
                                  String sheetName,
                                  String selectFields,
                                  String tableName,
                                  Boolean fileIncludesHeaders)
        {
            DataSet dataSet = null;
            DataTable dtReturn = null;
            string connectionString = string.Empty;
            string commandText = string.Empty;

            // Indicates the Excel file with header or not.
            string headerYesNo = string.Empty;
            string fileExtension = string.Empty;
            try
            {
                if (fileIncludesHeaders == true)
                {
                    // Set YES if excel WithHeader is TRUE.
                    headerYesNo = "YES";
                }
                else
                {
                    // Set NO if excel WithHeader is FALSE.
                    headerYesNo = "NO";
                }

                // Gets file extension for checking.
                fileExtension = Path.GetExtension(filePath);

                switch (fileExtension.ToUpper())
                {
                    case ".XLS":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    case ".XLSX":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    default:

                        throw new Exception("File is invalid.");
                }

                commandText = string.Format("SELECT {0} FROM [{1}$]",
                                            selectFields,
                                            sheetName);

                dataSet = new DataSet();
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    OleDbCommand dbCommand = new OleDbCommand(commandText, dbConnection);
                    dbCommand.CommandType = CommandType.Text;
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(dbCommand);
                    dbDataAdapter.Fill(dataSet);
                }

                if (dataSet != null &&
                    dataSet.Tables.Count > 0)
                {
                    dataSet.Tables[0].TableName = tableName;

                    // Sets reference of data table.
                    dtReturn = dataSet.Tables[tableName];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtReturn;
        }

        public void playOK()
        {
            string exePath = Application.StartupPath + "\\OK.wav";
            SoundPlayer simpleSound = new SoundPlayer(exePath);
            simpleSound.Play();
            return;
        }

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            result = ofdExcel.ShowDialog(); // Show the dialog.
            //playOK();
            lbFileName.Text = result.ToString().Trim();
        }

        public void playNG()
        {
            string exePath = Application.StartupPath + "\\OO.wav";
            SoundPlayer simpleSound = new SoundPlayer(exePath);
            simpleSound.Play();
            return;
        }
    }
}
