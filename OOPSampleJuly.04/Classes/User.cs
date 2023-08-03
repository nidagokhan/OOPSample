using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSampleJuly._04.Classes
{
    public class User
    {
        public User(string _kullaniciAdi, string _Sifre)
        {
            KullaniciAdi = _kullaniciAdi;
            Sifre = _Sifre;
        }

        string _sifre; //field
        public string KullaniciAdi { get; set; }
        public string Sifre {
            get
            {
                return _sifre;
            }
            set
            {
                if (value.Length<4)
                {
                   MessageBox.Show("Şifre 4 haneli olmalı");
                    Application.Restart();
                }
                _sifre= value;
            } 
        }
    }
}
