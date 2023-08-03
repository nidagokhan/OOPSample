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
    public partial class Form2 : Form
    {
        public Form2(User user)
        {
            InitializeComponent();
            UserInformation=user;
        }

        User UserInformation;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text==UserInformation.KullaniciAdi && txtSifre.Text==UserInformation.Sifre)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
