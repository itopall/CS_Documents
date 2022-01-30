using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_VisualInheritance
{
    public partial class BaseForm : Form
    {
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

        //Türeyen sınıflardan bazılarında picturebox'ın görünmemesini isteyebiliriz. aşağıdaki property'e türeyen sınıftan true ya da false atayarak resmin görünüp görünmeme durumunu türeyen sınıfta belirtebiliriz.
        protected bool ResimGoruntule
        {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }

        //ResimGoruntule property'sinde olduğu gibi burada da progressBar'ın value değerinin türeyen sınıftan yönetilebilmesini sağladık.
        protected int ProgressDegeri
        {
            get { return toolStripProgressBar1.Value; }
            set
            {
                if(value >= toolStripProgressBar1.Minimum && value <= toolStripProgressBar1.Maximum)
                    toolStripProgressBar1.Value = value;
            }
        }
    }
}
