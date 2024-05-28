using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EjemploGuru
{
    public interface IProduct
    {
        public string Name { get; set; }
        void DoSomething();
    }
}
