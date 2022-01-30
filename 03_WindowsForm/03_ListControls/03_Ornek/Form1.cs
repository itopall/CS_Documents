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

        //Soru;
        //Bir tane Textbox: Isim
        //Bir tane Textbox: Soyisim
        //Bir tane Combobox: Bölüm, içerisinde bölümler listelenecek
        //Bir tane Combobox: Ders, içerisinde dersler listelenecek
        //En altta bir tane button: Ekle, bu butona basınca en alttaki listbox'a eklensin
        //Silme ve güncelleme işlemleri de yapılsın.

        //Listbox'a ekleme formatı: Isim - Soyisim - Bölüm - Ders


        //Soru;
        //İki tane Textbox: Sayi1 ve Sayi2
        //Altlarına 4 tane checkbox: Topla, Cikar, Carp, Bol
        //Altlarına bir tane button: Hesapla
        //Altlarına bir tane listbox: Sayi1 + Sayi2 = Sonuc formatında sonuçlar yazılacak

        //checked property'si true ise seçili demektir. 


        //Soru
        //Şampiyonlar Ligi Kura Çekimi :)
        //Bir tane Textbox: Takım
        //Bir tane button: Takım Ekle
        //Altında bir tane Listbox: Takımlar
        //Sağ tarafta bir tane button: Kura Çek
        //Sağ üst tarafta bir tane Listbox: Grup-1
        //Altında bir tane Listbox daha: Grup-2
        //Kura Çek butonuna her tıklandığında bir takım sağ taraftaki gruplara sırayla önce Grup1 sonra Grup2 dolacak şekilde aktarılacak. Aktarılan takım sol taraftaki listeden silinecek

        //Bonus: Arkaplanda şampiyonlar ligi müziği çalsın. :)
    }
}
