using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSampleJuly._02.Classes
{
    public class Sinema
    {
        public int SalonNo { get; set; }
        public int KoltukSayisi { get; set; }
        public string FilmAdi { get; set; }
        public DateTime FilmSaati { get; set; }
        public override string ToString()
        {
            return SalonNo.ToString();
        }
    }
}
