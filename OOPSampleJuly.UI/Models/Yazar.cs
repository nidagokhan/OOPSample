using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleJuly.UI.Models
{
    public class Yazar
    {
        public string YazarAdi { get; set; }
        public string YazarSoyismi { get; set; }

        public void Yaz(string KitapAdi)
        {
            MessageBox.Show($"{KitapAdi}, {YazarAdi} {YazarSoyismi} adlı yazarın kitabıdır.");
        }

        public override string ToString()
        {
            return YazarAdi+" "+YazarSoyismi;
        }
    }
}
