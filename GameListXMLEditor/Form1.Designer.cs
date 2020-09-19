namespace GameListXMLEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblPublish = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNameFile = new System.Windows.Forms.CheckBox();
            this.chkValidate = new System.Windows.Forms.CheckBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCopyImages = new System.Windows.Forms.CheckBox();
            this.tbExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GameList.xml File Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(349, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 19);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(9, 27);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(338, 20);
            this.tbPath.TabIndex = 9;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 319);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(62, 25);
            this.btnProcess.TabIndex = 17;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblPublish
            // 
            this.lblPublish.AutoSize = true;
            this.lblPublish.Location = new System.Drawing.Point(79, 325);
            this.lblPublish.Name = "lblPublish";
            this.lblPublish.Size = new System.Drawing.Size(52, 13);
            this.lblPublish.TabIndex = 22;
            this.lblPublish.Text = "Waiting...";
            this.lblPublish.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNameFile);
            this.groupBox2.Controls.Add(this.chkValidate);
            this.groupBox2.Controls.Add(this.btnBrowse2);
            this.groupBox2.Controls.Add(this.tbImagePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkCopyImages);
            this.groupBox2.Controls.Add(this.tbExt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 219);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options:";
            // 
            // chkNameFile
            // 
            this.chkNameFile.AutoSize = true;
            this.chkNameFile.Location = new System.Drawing.Point(18, 30);
            this.chkNameFile.Name = "chkNameFile";
            this.chkNameFile.Size = new System.Drawing.Size(163, 17);
            this.chkNameFile.TabIndex = 32;
            this.chkNameFile.Text = "Copy \"File Name\" to \"Name\"";
            this.chkNameFile.UseVisualStyleBackColor = true;
            this.chkNameFile.CheckedChanged += new System.EventHandler(this.chkNameFile_CheckedChanged);
            // 
            // chkValidate
            // 
            this.chkValidate.AutoSize = true;
            this.chkValidate.Location = new System.Drawing.Point(18, 92);
            this.chkValidate.Name = "chkValidate";
            this.chkValidate.Size = new System.Drawing.Size(101, 17);
            this.chkValidate.TabIndex = 31;
            this.chkValidate.Text = "Validate Images";
            this.chkValidate.UseVisualStyleBackColor = true;
            this.chkValidate.CheckedChanged += new System.EventHandler(this.chkValidate_CheckedChanged);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(382, 133);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(31, 19);
            this.btnBrowse2.TabIndex = 30;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Enabled = false;
            this.tbImagePath.Location = new System.Drawing.Point(38, 133);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(338, 20);
            this.tbImagePath.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Images Source Path:";
            // 
            // chkCopyImages
            // 
            this.chkCopyImages.AutoSize = true;
            this.chkCopyImages.Location = new System.Drawing.Point(18, 69);
            this.chkCopyImages.Name = "chkCopyImages";
            this.chkCopyImages.Size = new System.Drawing.Size(146, 17);
            this.chkCopyImages.TabIndex = 27;
            this.chkCopyImages.Text = "Update and Copy Images";
            this.chkCopyImages.UseVisualStyleBackColor = true;
            this.chkCopyImages.CheckedChanged += new System.EventHandler(this.chkCopyImages_CheckedChanged);
            // 
            // tbExt
            // 
            this.tbExt.Enabled = false;
            this.tbExt.Location = new System.Drawing.Point(38, 177);
            this.tbExt.Name = "tbExt";
            this.tbExt.Size = new System.Drawing.Size(152, 20);
            this.tbExt.TabIndex = 26;
            this.tbExt.Text = ".png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Image extension to use:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPublish);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GameList XML Editor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblPublish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNameFile;
        private System.Windows.Forms.CheckBox chkValidate;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.TextBox tbImagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCopyImages;
        private System.Windows.Forms.TextBox tbExt;
        private System.Windows.Forms.Label label4;
    }
}

