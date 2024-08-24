using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Validasyon
{
    public class RequiredFieldValidator
    {
        public static List<string> Validate(object objectToValidate)
        {
            List<string> missingFields = new List<string>();
            Type objectType = objectToValidate.GetType();

            //Check fields

            FieldInfo[] fieldsToValidate = objectType.GetFields(BindingFlags.Instance | BindingFlags.Public);

            foreach (FieldInfo field in fieldsToValidate)
            {
                object[] requiredAttributes = field.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);

                if (requiredAttributes.Length > 0)
                {
                    string fieldValue = field.GetValue(objectToValidate) as string;

                    if (string.IsNullOrEmpty(fieldValue))
                    {
                        missingFields.Add(field.Name);
                    }
                }
            }

            // Check properties
            PropertyInfo[] propertiesToValidate = objectType.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (PropertyInfo property in propertiesToValidate)
            {
                object[] requiredAttributes = property.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);

                if (requiredAttributes.Length != 0)
                {
                    string propertyValue = property.GetValue(objectToValidate) as string;

                    if (string.IsNullOrEmpty(propertyValue))
                    {
                        missingFields.Add(property.Name);
                    }
                }
            }

            return missingFields;

        }


    }
}
