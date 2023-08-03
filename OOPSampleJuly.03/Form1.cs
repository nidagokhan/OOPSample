using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSampleJuly._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            int Red = trcRed.Value;
            int Green = trcGreen.Value;
            int Blue = trcBlue.Value;

            Form2 form2 = new Form2(Red,Green,Blue);
            form2.Show();
        }

        private void btnIsimile_Click(object sender, EventArgs e)
        {
            string Name=textBox1.Text;
            Form2 form = new Form2(Name);
            form.Show();

        }
    }
}
