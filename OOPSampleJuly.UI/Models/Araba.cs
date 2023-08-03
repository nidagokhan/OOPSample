using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleJuly.UI.Models
{
    public  class Araba
    {
        //arabanın nesi var sorusu bize property verir

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Hiz { get; set; }
        public int Vites { get; set; }

        //araba ne yapabilir sorunun cevabı metodu oluşturacak
    }
}
