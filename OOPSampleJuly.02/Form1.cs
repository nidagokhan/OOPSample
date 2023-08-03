using OOPSampleJuly._02.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSampleJuly._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sinema> sinema = new List<Sinema>()
            {
                new Sinema()
                {
                    SalonNo=1,
                    KoltukSayisi=30,
                    FilmAdi="Barbie",
                    FilmSaati=DateTime.Now
                    
                },
                new Sinema()
                {
                    SalonNo=2,
                    KoltukSayisi=15,
                    FilmAdi="Titanic"
                },
                new Sinema()
                {
                    SalonNo=3,
                    KoltukSayisi=20,
                    FilmAdi="Kürk Mantolu Madonna",
                    FilmSaati=DateTime.Today
                },
                new Sinema()
                {
                    SalonNo=4,
                    KoltukSayisi=30,
                    FilmAdi="Çizmeli Kedi",
                    FilmSaati=DateTime.Today
                }
            };

            foreach (Sinema s in sinema)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sinema secilenSalon = comboBox1.SelectedItem as Sinema;
            label1.Text = secilenSalon.FilmAdi;
            label2.Text=secilenSalon.KoltukSayisi.ToString();
            label3.Text=secilenSalon.FilmSaati.ToString();
        }
    }
}
