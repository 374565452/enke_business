using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTUGateWay
{
    public partial class FrmDownload : Form
    {
        public FrmDownload()
        {
            InitializeComponent();
            downloadWorker = new DownloadDataWorker();
            downloadWorker.valueChanged += downloadWorker_valueChanged;
            CheckForIllegalCrossThreadCalls = false;
        }

        void downloadWorker_valueChanged(object sender, ValueEventArgs e)
        {
            //throw new NotImplementedException();
            this.progressBar1.Value += e.Value;
        }

        private DownloadDataWorker downloadWorker;

        private void fileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (fileTypeCb.SelectedIndex == 0)
            {
                op.Filter = "bin文件(*.bin)|*.bin";
            }
            else
            {
                op.Filter = "bin文件(*.bin)|*.bin";
            }
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.fileTxt.Text = op.FileName;
            }
            else
            {
                this.fileTxt.Text = "";
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            string filePath = this.fileTxt.Text;
            if (filePath == null || filePath.Equals(""))
            {
                MessageBox.Show("没有选择程序文件！");
                return;
            }
            string ext = Path.GetExtension(filePath);
            if (!ext.Equals(".bin"))
            {
                MessageBox.Show("错误，程序文件格式不正确！");
                return;
            }
            FileInfo fileInfo = new FileInfo(filePath);
            this.progressBar1.Maximum = (int)fileInfo.Length;
        }

        private void FrmDownload_Shown(object sender, EventArgs e)
        {

        }
    }
}
