using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_VisualInheritance
{
    public partial class BaseForm : Form
    {
        //OOP Kalıtım konusunda olduğu gibi formlar üzerinde kalıtım işlemi gerçekleştirebiliriz.
        //BaseForm: Form class'ından türemektedir. BaseForm'un içerisine ortak kullanılacak menu, statusbar gibi kontrolleri ekleyip diğer formların BaseForm'dan türetilip kullanılmasını sağlayarak her formun içerisinde bu kontrolleri tekrar tekrar çoklamadan tek bir Ana Form'dan yönetilmesini sağlayabiliriz.
        public BaseForm()
        {
            InitializeComponent();
        }

        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Show();
        }

        private void ıletisimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim iletisim = new Iletisim();
            iletisim.Show();
        }
    }
}
