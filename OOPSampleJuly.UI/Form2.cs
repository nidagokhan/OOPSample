using OOPSampleJuly.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSampleJuly.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenYazar=comboBox1.SelectedItem.ToString();

            if (secilenYazar=="Halit Ziya Uşaklıgil")
            {
                MessageBox.Show("Aşkı Memnu");
            }
            else
            {
                MessageBox.Show("Kürt Mantolu Madonna");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Yazar> yazar = new List<Yazar>()
            {
               new Yazar()
                {
                    YazarAdi="Halit Ziya",
                    YazarSoyismi="Uşaklıgil"
                },
                new Yazar()
                {
                    YazarAdi="Sabahattin",
                    YazarSoyismi="Ali"
                }
            };
            foreach (var item in yazar)
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
