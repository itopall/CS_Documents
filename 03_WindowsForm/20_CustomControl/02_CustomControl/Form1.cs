using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CustomControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CharStyle'ı Lower olarak belirlersek hep küçük yazılacak, Upper seçilirse hep büyük yazılacak
            bigCharTextbox1.CharStyle = _01_MyCustomControls.BigCharTextbox.CharType.Lower;

            //colorButton1.Renk = Color.Orange;
        }
    }
}
