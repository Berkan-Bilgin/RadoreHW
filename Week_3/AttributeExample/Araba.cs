using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    public class Araba
    {
        public string marka;
        public string model;

        public int Yil { get; set; }
        public string Renk { get; set; }

        public Araba(string marka, string model, int yil, string renk)
        {
            this.marka = marka;
            this.model = model;
            Yil = yil;
            Renk = renk;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Yıl: {Yil}, Renk: {Renk}");
        }
    }
}
