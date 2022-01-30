using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Araba Yarışı Ödevi
        //Form'a iki tane picturebox ekleyip içerisine araba resimleri atayalım. Bir tane Başla bir tane de Dur butonumuz olsun.
        //Başla butonuna her tıkladığımızda arabaların her ikisi de farklı bir hız belirlenerek(Random) soldan sağa doğru hareket etmeye başlasın.
        //(Timer!) Dur butonuna bastığımızda ise her ikisi de dursun.
        //Ekranın sağ tarafında bir yere ise Finish çizgisi koyalım ve buraya ilk ulaşan aracın adı Tebrikler Mesajı ile ekranda gösterilsin.

        //JackPot oyunu ödevi
        //Ekrana üç tane resim koyup Başlat butonuna tıklandığında resimlerin sürekli değişmesini sağlayıp Dur butonuna basıldığında resimlerin durup 3 resmin de aynı gelmesi durumunda büyük ödülü kazandınız mesajının janjanlı bir şekilde gösterilmesi sağlanacak. Diğer durumlarda ise kaybettiniz mesajı görüntülenecek. 

    }
}
