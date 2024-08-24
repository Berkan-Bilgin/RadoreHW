using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validasyon
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adı { get; set; }

        [ZorunluAlan]
        public string Soyadı { get; set; }

        [ZorunluAlan]
        public string Bolum { get; set; }
    }
}
