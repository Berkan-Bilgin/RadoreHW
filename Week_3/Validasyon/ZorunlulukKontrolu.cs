using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Validasyon
{
    public class ZorunlulukKontrolu
    {
        public static bool Dogrula(object dogrulanacakNesne)
        {
            Type dogrulanacakTur = dogrulanacakNesne.GetType();

            FieldInfo[] dogrulanacakAlanlar = dogrulanacakTur.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo dogrulanacakAlan in dogrulanacakAlanlar)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakAlan.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);

                if (zorunluAlanOznitelikleri.Length > 0)
                {
                    string alanDeger = dogrulanacakAlan.GetValue(dogrulanacakNesne) as string;


                    if (string.IsNullOrEmpty(alanDeger))
                    {
                        return false;
                    }

                }
            }

            PropertyInfo[] dogrulanacakOzellikler = dogrulanacakTur.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (PropertyInfo dogrulanacakOzellik in dogrulanacakOzellikler)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakOzellik.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);

                if (zorunluAlanOznitelikleri.Length > 0)
                {
                    string ozellikDeger = dogrulanacakOzellik.GetValue(dogrulanacakNesne) as string;

                    if (string.IsNullOrEmpty(ozellikDeger))
                    {
                        return false;

                    }

                }
            }
            return true;
        }
    }
}
