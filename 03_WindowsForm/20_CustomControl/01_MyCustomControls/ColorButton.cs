using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MyCustomControls
{
    public partial class ColorButton : Button //Button'dan kalıtım aldık
    {
        public ColorButton()
        {
            InitializeComponent();

            temp = BackColor;

            MouseEnter += ColorButton_MouseEnter;
            MouseLeave += ColorButton_MouseLeave;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Color Renk { get; set; }
        Color temp;

        private void ColorButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Renk;
        }

        private void ColorButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = temp;
        }
    }
}
