using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public string Kolor { get; set; }
        public bool Dostepny { get; set; }

        public Samochod(string marka, string model, int rocznik, string kolor, bool dostepny)
        {
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            Kolor = kolor;
            Dostepny = dostepny;
        }
    }
}
