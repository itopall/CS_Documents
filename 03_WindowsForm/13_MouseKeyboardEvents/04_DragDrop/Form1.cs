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

namespace _04_DragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bir kontrol üzerinde sürükle-bırak ile işlem yapmak istiyorsak öncelikli olarak hedef kontrolün AllowDrop özelliğini true olarak set etmemiz gerekir.
        private void Form1_Load(object sender, EventArgs e)
        {
            lstUrunler.AllowDrop = true;

            LoadUrunler();
        }

        //Ürün listesi formun load'ında açılıyor.
        private void LoadUrunler()
        {
            lstUrunler.Items.AddRange(File.ReadAllLines("..//..//Urunler.txt"));
        }

        //Delete'e basıldığında seçili ürünü siliyoruz
        private void lstUrunler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                lstUrunler.Items.Remove(lstUrunler.SelectedItem);
        }

        //Ürün listesine masaüstünden ya da herhangi bir klasörden sürükle-bırak yöntemi ile ürün eklenmesini sağlıyoruz
        //Not: lstUrun'ün AllowDrop özelliğinin true olarak ayarlanması gerekir.
        private void lstUrunler_DragDrop(object sender, DragEventArgs e)
        {
            string[] dosyalar = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (dosyalar != null)
            {
                foreach (var dosya in dosyalar)
                    lstUrunler.Items.AddRange(File.ReadAllLines(dosya));
            }
        }

        private void lstUrunler_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
