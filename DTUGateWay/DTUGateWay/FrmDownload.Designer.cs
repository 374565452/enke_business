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
<<<<<<< HEAD
            this.label2 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.totalFrameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentFrameLabel = new System.Windows.Forms.Label();
=======
>>>>>>> 7993a0bc2e118a304eafc87fecbeefda72129d41
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
<<<<<<< HEAD
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "服务器连接状态：";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Red;
            this.stateLabel.Location = new System.Drawing.Point(379, 21);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(53, 12);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "连接失败";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "共：";
            // 
            // totalFrameLabel
            // 
            this.totalFrameLabel.AutoSize = true;
            this.totalFrameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totalFrameLabel.Location = new System.Drawing.Point(52, 136);
            this.totalFrameLabel.Name = "totalFrameLabel";
            this.totalFrameLabel.Size = new System.Drawing.Size(11, 12);
            this.totalFrameLabel.TabIndex = 9;
            this.totalFrameLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前帧：";
            // 
            // currentFrameLabel
            // 
            this.currentFrameLabel.AutoSize = true;
            this.currentFrameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentFrameLabel.Location = new System.Drawing.Point(149, 136);
            this.currentFrameLabel.Name = "currentFrameLabel";
            this.currentFrameLabel.Size = new System.Drawing.Size(11, 12);
            this.currentFrameLabel.TabIndex = 11;
            this.currentFrameLabel.Text = "0";
            // 
=======
>>>>>>> 7993a0bc2e118a304eafc87fecbeefda72129d41
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 192);
<<<<<<< HEAD
            this.Controls.Add(this.currentFrameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalFrameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label2);
=======
>>>>>>> 7993a0bc2e118a304eafc87fecbeefda72129d41
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
<<<<<<< HEAD
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalFrameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentFrameLabel;
=======
>>>>>>> 7993a0bc2e118a304eafc87fecbeefda72129d41
    }
}