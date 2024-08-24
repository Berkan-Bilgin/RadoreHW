using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string adi;
        [ZorunluAlan]
        public string soyadi;
        [ZorunluAlan]
        public string bolum;

        [ZorunluAlan]
        public string sinif { get; set; }
    }
}
