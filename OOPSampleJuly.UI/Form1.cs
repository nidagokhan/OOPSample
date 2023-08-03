using OOPSampleJuly.UI.Models;

namespace OOPSampleJuly.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba();

            araba.Marka = "Volvo";
            araba.Model = "2023";
            araba.Renk = "Ihlamur";
            araba.Hiz = 260;
            araba.Vites = 6;

            MessageBox.Show($"{araba.Marka} is mine <3");
        }
    }
}