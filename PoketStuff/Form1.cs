using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace PoketStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RustCfgDl_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://getfile.dokpub.com/yandex/get/https://yadi.sk/d/SRT68CbNzYcS9w"), @".\RustCFG.rar");
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Файл закачан");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 1)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri("https://getfile.dokpub.com/yandex/get/https://yadi.sk/d/SRT68CbNzYcS9w"), @".\RustCFG.rar");
            }
            if (listBox1.SelectedIndex != 0 || listBox1.SelectedIndex != 1) 
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileAsync(new Uri("https://getfile.dokpub.com/yandex/get/https://yadi.sk/d/SRT68CbNzYcS9w"), @".\cerf.rar");
            }
            
        }
    }


}

