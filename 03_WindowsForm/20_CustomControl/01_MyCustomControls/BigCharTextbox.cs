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
    public partial class BigCharTextbox : TextBox //Bir textbox üzerinde geliştirme yaptığımızı belirttik
    {
        public BigCharTextbox()
        {
            InitializeComponent();

            KeyPress += BigCharTextBox_KeyPress; //new KeyPressEventHandler(BigCharTextBox_KeyPress); 
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public enum CharType
        {
            Upper,
            Lower
        }

        //CharStyle bilgisi property olarak property listesinde görünecek
        public CharType CharStyle { get; set; }

        private void BigCharTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (CharStyle)
            {
                case CharType.Upper:
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                    break;
                case CharType.Lower:
                    e.KeyChar = Char.ToLower(e.KeyChar);
                    break;
                default:
                    break;
            }
        }
    }
}
