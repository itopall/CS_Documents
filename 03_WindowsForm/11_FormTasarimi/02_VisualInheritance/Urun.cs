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
    public partial class Urun : BaseForm //BaseForm'dan türeterek ortak menu vs gibi kontrollerin BaseForm'dan alınmasını sağladık.
    {
        public Urun()
        {
            InitializeComponent();
        }
    }
}
