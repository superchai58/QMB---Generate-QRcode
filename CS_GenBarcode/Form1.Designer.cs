namespace CS_GenBarcode
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcbBarCode = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pcbLoad = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbFileName = new System.Windows.Forms.Label();
            this.rdoManual = new System.Windows.Forms.RadioButton();
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.rdoUploadExcel = new System.Windows.Forms.RadioButton();
            this.txtManual = new System.Windows.Forms.TextBox();
            this.btnSavePDF = new System.Windows.Forms.Button();
            this.bgwUoloadManual = new System.ComponentModel.BackgroundWorker();
            this.bgwUploadFile = new System.ComponentModel.BackgroundWorker();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarCode)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 54);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "GEN BARCODE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(379, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 535);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How to use";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 72);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. Select the type that you want to generate barcode.\r\n2. Add data via text box o" +
    "r upload file (.xlsx or .xls and first colum is \"SN\").\r\n3. Press the button to p" +
    "rint the PDF file.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pcbBarCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 431);
            this.panel4.TabIndex = 1;
            // 
            // pcbBarCode
            // 
            this.pcbBarCode.Location = new System.Drawing.Point(84, 78);
            this.pcbBarCode.Name = "pcbBarCode";
            this.pcbBarCode.Size = new System.Drawing.Size(331, 250);
            this.pcbBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBarCode.TabIndex = 0;
            this.pcbBarCode.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 535);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pcbLoad);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 210);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(379, 325);
            this.panel8.TabIndex = 7;
            // 
            // pcbLoad
            // 
            this.pcbLoad.ErrorImage = null;
            this.pcbLoad.Image = ((System.Drawing.Image)(resources.GetObject("pcbLoad.Image")));
            this.pcbLoad.InitialImage = null;
            this.pcbLoad.Location = new System.Drawing.Point(18, 19);
            this.pcbLoad.Name = "pcbLoad";
            this.pcbLoad.Size = new System.Drawing.Size(340, 277);
            this.pcbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLoad.TabIndex = 0;
            this.pcbLoad.TabStop = false;
            this.pcbLoad.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.btnSavePDF);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(379, 210);
            this.panel7.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel9.Controls.Add(this.lbFileName);
            this.panel9.Controls.Add(this.rdoManual);
            this.panel9.Controls.Add(this.btnUploadExcel);
            this.panel9.Controls.Add(this.lbText);
            this.panel9.Controls.Add(this.rdoUploadExcel);
            this.panel9.Controls.Add(this.txtManual);
            this.panel9.Location = new System.Drawing.Point(18, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(340, 93);
            this.panel9.TabIndex = 1;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.BackColor = System.Drawing.Color.Transparent;
            this.lbFileName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.ForeColor = System.Drawing.Color.Black;
            this.lbFileName.Location = new System.Drawing.Point(286, 52);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(49, 19);
            this.lbFileName.TabIndex = 1;
            this.lbFileName.Text = "label3";
            this.lbFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoManual
            // 
            this.rdoManual.AutoSize = true;
            this.rdoManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoManual.Location = new System.Drawing.Point(6, 7);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(76, 23);
            this.rdoManual.TabIndex = 1;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "Manual";
            this.rdoManual.UseVisualStyleBackColor = true;
            this.rdoManual.CheckedChanged += new System.EventHandler(this.rdoManual_CheckedChanged);
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUploadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadExcel.Location = new System.Drawing.Point(88, 45);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(192, 33);
            this.btnUploadExcel.TabIndex = 3;
            this.btnUploadExcel.Text = "Upload Excel";
            this.btnUploadExcel.UseVisualStyleBackColor = false;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(2, 52);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(80, 26);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "Upload";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoUploadExcel
            // 
            this.rdoUploadExcel.AutoSize = true;
            this.rdoUploadExcel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUploadExcel.Location = new System.Drawing.Point(88, 7);
            this.rdoUploadExcel.Name = "rdoUploadExcel";
            this.rdoUploadExcel.Size = new System.Drawing.Size(107, 23);
            this.rdoUploadExcel.TabIndex = 2;
            this.rdoUploadExcel.TabStop = true;
            this.rdoUploadExcel.Text = "UploadExcel";
            this.rdoUploadExcel.UseVisualStyleBackColor = true;
            this.rdoUploadExcel.CheckedChanged += new System.EventHandler(this.rdoUploadExcel_CheckedChanged);
            // 
            // txtManual
            // 
            this.txtManual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManual.Location = new System.Drawing.Point(88, 49);
            this.txtManual.Name = "txtManual";
            this.txtManual.Size = new System.Drawing.Size(192, 27);
            this.txtManual.TabIndex = 4;
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSavePDF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePDF.Location = new System.Drawing.Point(18, 126);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.Size = new System.Drawing.Size(340, 51);
            this.btnSavePDF.TabIndex = 5;
            this.btnSavePDF.Text = "Save to PNG";
            this.btnSavePDF.UseVisualStyleBackColor = false;
            this.btnSavePDF.Click += new System.EventHandler(this.btnSavePDF_Click);
            // 
            // bgwUoloadManual
            // 
            this.bgwUoloadManual.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUoloadManual_DoWork);
            this.bgwUoloadManual.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUoloadManual_RunWorkerCompleted);
            // 
            // bgwUploadFile
            // 
            this.bgwUploadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUploadFile_DoWork);
            this.bgwUploadFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUploadFile_RunWorkerCompleted);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(885, 589);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGenBarCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarCode)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoad)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pcbBarCode;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pcbLoad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdoManual;
        private System.Windows.Forms.Button btnSavePDF;
        private System.Windows.Forms.RadioButton rdoUploadExcel;
        private System.Windows.Forms.TextBox txtManual;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnUploadExcel;
        private System.ComponentModel.BackgroundWorker bgwUoloadManual;
        private System.ComponentModel.BackgroundWorker bgwUploadFile;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Panel panel9;
    }
}

