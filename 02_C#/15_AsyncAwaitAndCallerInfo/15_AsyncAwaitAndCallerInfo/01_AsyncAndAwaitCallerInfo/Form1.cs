using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_AsyncAndAwaitCallerInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStartCall_Click(object sender, EventArgs e)
        {
            int contentLength = await AsyncBaglan();

            txtMessage.Text += $"\r\nMetinin uzunluğu: {contentLength}";
        }

        private async Task<int> AsyncBaglan()
        {
            HttpClient client = new HttpClient();
            Task<string> getStirngTask = client.GetStringAsync("http://msdn.microsoft.com");

            AraIslemYap();


            string urlContent = await getStirngTask;
            txtMessage.Text += urlContent;
            return urlContent.Length;
        }

        private void AraIslemYap()
        {
            txtMessage.Text += "Ara işlem yapılıyor............\r\n";
        }
    }
}
