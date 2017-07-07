namespace DTUGateWay
{
    partial class FrmDownload
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
            this.fileTypeCb = new System.Windows.Forms.ComboBox();
            this.fileTxt = new System.Windows.Forms.TextBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件类型：";
            // 
            // fileTypeCb
            // 
            this.fileTypeCb.FormattingEnabled = true;
            this.fileTypeCb.Items.AddRange(new object[] {
            "更新程序"});
            this.fileTypeCb.Location = new System.Drawing.Point(103, 34);
            this.fileTypeCb.Name = "fileTypeCb";
            this.fileTypeCb.Size = new System.Drawing.Size(121, 20);
            this.fileTypeCb.TabIndex = 1;
            // 
            // fileTxt
            // 
            this.fileTxt.Location = new System.Drawing.Point(34, 80);
            this.fileTxt.Name = "fileTxt";
            this.fileTxt.Size = new System.Drawing.Size(263, 21);
            this.fileTxt.TabIndex = 2;
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(334, 77);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(75, 23);
            this.fileBtn.TabIndex = 3;
            this.fileBtn.Text = "选择文件";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(334, 124);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 4;
            this.downloadBtn.Text = "下载";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 192);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.fileTxt);
            this.Controls.Add(this.fileTypeCb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件下发";
            this.Shown += new System.EventHandler(this.FrmDownload_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fileTypeCb;
        private System.Windows.Forms.TextBox fileTxt;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}