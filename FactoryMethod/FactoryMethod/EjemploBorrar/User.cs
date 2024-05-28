using FactoryMethod.EJEMPLO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO
{
    public class User
    {
        public UserPreferences Preference { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
