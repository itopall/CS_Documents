using _01_ResxFile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ResxFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Resource (resx) dosyaları içerisinde metin, resim ve dosyalar barındırabilirler. Bir proje içerisine birden fazla resx dosyası eklenebilir. Bu dosyalara çift tıklandıktan sonra açılan ekrandan yeni metin, dosya ya da resim eklenebilir.
        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.BackgroundImage = Resources.pikaçu;
            //pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Image = Resources.pikaçu;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Mesajlar.resc dosyası içerisine form üzerinde bulunan button ve label nesneleri için eklediğimiz text mesajını alıp ilgili component'in Text özelliğine ekliyoruz.
            button1.Text = Mesajlar.button1;
            button2.Text = Mesajlar.button2;
            button3.Text = Mesajlar.button3;
            label1.Text = Mesajlar.label1;
            label2.Text = Mesajlar.label2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Properties altındaki Resources.resx kaynak dosyası içerisine eklediğimiz GirisMesaji adındaki metine erişip ekrana basıyoruz.

            //1. Yöntem
            MessageBox.Show(Resources.GirisMesaji);

            //2. Yöntem
            ResourceManager rm = new ResourceManager("_01_ResxFile.Properties.Resources", Assembly.GetExecutingAssembly());

            MessageBox.Show(rm.GetString("GirisMesaji"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hata mesajını direk string olarak burada yazmadık! Mesajlar kaynak dosyasının içerisine yazıp oradan çağırma işlemi yaptık.
            MessageBox.Show(Mesajlar.loginHataMesaji);
        }
    }
}
