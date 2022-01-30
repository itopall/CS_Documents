using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_OwnerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Owner property'si aracılığıyla bir formu başka bir formun sahip formu olarak tanımlayabiliriz. 
            //Bu kullanım formlar arası veri taşımalarda kolaylık sağlar.
            Form2 form2 = new Form2();

            //Ürettiğimiz formun Owner property'sine, üreten formu(this) atadık.
            //form2.Owner = this;

            //Bir form başka bir formu görüntülerken Owner'ını söyleyebilir.
            form2.Show(this); //Form2'nin Owner'ı Form1 oldu
        }

        public void HareketEttir(int deger)
        {
            txtGidenMesaj.Top += deger;
        }

        public void YanaHareketEttir(int deger)
        {
            txtGidenMesaj.Left += deger;
        }

        //Form2'ye txtGidenMesaj nesnesini vermek yerine, bu kontrolün Text'ini verdik.
        //Böylece kontrole direkt erişemediğinden oluşabilecek sorunların önüne geçmiş olduk
        public string Mesaj
        {
            get { return txtGidenMesaj.Text; }
            set { txtGidenMesaj.Text = value; }
        }
    }
}
