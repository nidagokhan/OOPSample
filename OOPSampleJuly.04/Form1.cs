using OOPSampleJuly._04.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSampleJuly._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            User user=new User(txtKullaniciAdi.Text,txtSifre.Text);

            Form2 form2 = new Form2(user);
            this.Hide();
            form2.Show();

        }
    }
}
