namespace XLSXtoPDF
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.authorLbl = new System.Windows.Forms.Label();
            this.fldrBtn = new System.Windows.Forms.Button();
            this.fldrTB = new System.Windows.Forms.TextBox();
            this.pdfCnvrtBtn = new System.Windows.Forms.Button();
            this.hdrLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.mOfficeInstallation = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusLbl = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.snglCB = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.consoleTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 520);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorLbl.Location = new System.Drawing.Point(216, 493);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(149, 12);
            this.authorLbl.TabIndex = 1;
            this.authorLbl.Text = "Author: undercontr (Önder ALKAN)";
            // 
            // fldrBtn
            // 
            this.fldrBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fldrBtn.Location = new System.Drawing.Point(12, 239);
            this.fldrBtn.Name = "fldrBtn";
            this.fldrBtn.Size = new System.Drawing.Size(266, 23);
            this.fldrBtn.TabIndex = 2;
            this.fldrBtn.Text = "Klasör Seç";
            this.fldrBtn.UseVisualStyleBackColor = true;
            this.fldrBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fldrTB
            // 
            this.fldrTB.Location = new System.Drawing.Point(12, 212);
            this.fldrTB.Name = "fldrTB";
            this.fldrTB.Size = new System.Drawing.Size(350, 20);
            this.fldrTB.TabIndex = 3;
            // 
            // pdfCnvrtBtn
            // 
            this.pdfCnvrtBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfCnvrtBtn.Location = new System.Drawing.Point(12, 271);
            this.pdfCnvrtBtn.Name = "pdfCnvrtBtn";
            this.pdfCnvrtBtn.Size = new System.Drawing.Size(353, 23);
            this.pdfCnvrtBtn.TabIndex = 4;
            this.pdfCnvrtBtn.Text = "PDF\'e çevir";
            this.pdfCnvrtBtn.UseVisualStyleBackColor = true;
            this.pdfCnvrtBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // hdrLbl
            // 
            this.hdrLbl.AutoSize = true;
            this.hdrLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrLbl.Location = new System.Drawing.Point(48, 132);
            this.hdrLbl.Name = "hdrLbl";
            this.hdrLbl.Size = new System.Drawing.Size(281, 55);
            this.hdrLbl.TabIndex = 5;
            this.hdrLbl.Text = "XLSXtoPDF";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.descLbl.Location = new System.Drawing.Point(12, 194);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(230, 15);
            this.descLbl.TabIndex = 6;
            this.descLbl.Text = "Çevrilecek Klasör (alt klasörlerde çevrilir)";
            // 
            // mOfficeInstallation
            // 
            this.mOfficeInstallation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mOfficeInstallation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mOfficeInstallation.Location = new System.Drawing.Point(99, 115);
            this.mOfficeInstallation.Name = "mOfficeInstallation";
            this.mOfficeInstallation.Size = new System.Drawing.Size(179, 13);
            this.mOfficeInstallation.TabIndex = 7;
            this.mOfficeInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusLbl.Location = new System.Drawing.Point(11, 490);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(161, 15);
            this.statusLbl.TabIndex = 10;
            this.statusLbl.Text = "Şu anda çevirilen dosya yok.";
            // 
            // logoImage
            // 
            this.logoImage.Image = global::XLSXtoPDF.Properties.Resources.xlsxtopdf_icon;
            this.logoImage.InitialImage = null;
            this.logoImage.Location = new System.Drawing.Point(85, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(206, 100);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 11;
            this.logoImage.TabStop = false;
            // 
            // snglCB
            // 
            this.snglCB.AutoSize = true;
            this.snglCB.Location = new System.Drawing.Point(284, 243);
            this.snglCB.Name = "snglCB";
            this.snglCB.Size = new System.Drawing.Size(78, 17);
            this.snglCB.TabIndex = 12;
            this.snglCB.Text = "Tek Dosya";
            this.snglCB.UseVisualStyleBackColor = true;
            this.snglCB.CheckedChanged += new System.EventHandler(this.snglCB_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // consoleTB
            // 
            this.consoleTB.Cursor = System.Windows.Forms.Cursors.No;
            this.consoleTB.Location = new System.Drawing.Point(12, 300);
            this.consoleTB.Multiline = true;
            this.consoleTB.Name = "consoleTB";
            this.consoleTB.ReadOnly = true;
            this.consoleTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTB.Size = new System.Drawing.Size(352, 180);
            this.consoleTB.TabIndex = 13;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 555);
            this.Controls.Add(this.consoleTB);
            this.Controls.Add(this.snglCB);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.mOfficeInstallation);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.hdrLbl);
            this.Controls.Add(this.pdfCnvrtBtn);
            this.Controls.Add(this.fldrTB);
            this.Controls.Add(this.fldrBtn);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "XLSXtoPDF Klasör Çevirici";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Button fldrBtn;
        private System.Windows.Forms.TextBox fldrTB;
        private System.Windows.Forms.Button pdfCnvrtBtn;
        private System.Windows.Forms.Label hdrLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label mOfficeInstallation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.CheckBox snglCB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox consoleTB;
    }
}

