using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Localization
{
    public partial class Form1 : Form
    {
        //Kelimeler.resx, Kelimeler.en-US.resx, Kelimeler.tr-TR.resx olmak üzere 3 ayrı resource dosyası tanımladık ve üç dosyanın da içerisine str1, str2 ve str3 olmak üzere 3 farklı dilde karşılıklarını ekledik. Formun Load event'inde CultureInfo'yu belirleyerek ilgili resx dosyasından bilgilerin okunmasını sapladık ve böylelikle çoklu dil desteği sağlayan bir program yapısı tasarlamış olduk.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resource dosyalarının arasında de-DE olmadığı için aşağıdaki kod bloğu çalışırsa default dosya olan Kelimeler.resx deki değerler gelecektir.
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");

            //en-US ve tr-TR için resource dosyası yazıldığından dolayı ilgili dosyaların içindeki değerler kullanılacaktır.
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            lstWords.Items.Add(Kelimeler.str1);
            lstWords.Items.Add(Kelimeler.str2);
            lstWords.Items.Add(Kelimeler.str3);
        }
    }
}
