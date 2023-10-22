using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_2
{
    internal class Person
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string dogum { get; set; }
        public Person(string ad_, string soyad_, string email_, string tel_, string dogum_)
        {
            ad = ad_;
            soyad = soyad_;
            email = email_;
            tel = tel_;
            dogum = dogum_;
        }

        public override string ToString()
        {
            return $"{ad}";
        }
    }
}