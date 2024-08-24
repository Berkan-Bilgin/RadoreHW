using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validasyon;

namespace OgrenciForm
{
    public class Student
    {
        [ZorunluAlan]
        public string FirstName { get; set; }
        [ZorunluAlan]
        public string LastName { get; set; }
        [ZorunluAlan]
        public string Department { get; set; }
    }
}
