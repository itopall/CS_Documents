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
    public partial class Urun : BaseForm
    {
        public Urun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            //BaseForm'daki ResimGoruntule property'siyle resmin görünürlüğünü ayarladık
            //ResimGoruntule = false;

            //Ya da bu şekilde Controls property'si ile direkt picturebox1'in kendisine de erişebiliriz. Ancak bu yöntemi biraz hataya açık olduğu için fazla tercih etmemeliyiz.
            Controls["picturebox1"].Visible = false;
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            ProgressDegeri += 5;
        }

        private void btnEksilt_Click(object sender, EventArgs e)
        {
            ProgressDegeri -= 5;
        }
    }
}
