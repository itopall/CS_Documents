using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MyUserControl
{
    public partial class MyCombobox : UserControl
    {
        //userControl aracılığıyla kendi özel kontrollerimizi yazabiliriz ve bu kontrolleri birden fazla farklı yerde kullanabiliriz.
        public MyCombobox()
        {
            InitializeComponent();

            Load += MyCombobox_Load; //new EventHandler(MyCombobox_Load);
        }

        void MyCombobox_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            cbStatus.Items.Add("Yeni Kayıt");
            cbStatus.Items.Add("Onay Bekliyor");
            cbStatus.Items.Add("Onaylandı");
            cbStatus.Items.Add("Reddedildi");
            cbStatus.Items.Add("Tamamlandı");
            cbStatus.Items.Add("İptal Edildi");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem != null)
                MessageBox.Show("Seçili Nesne: " + cbStatus.SelectedItem.ToString());
        }

        public string SetLabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string SelectedText
        {
            get { return cbStatus.Text; }
        }
    }
}
