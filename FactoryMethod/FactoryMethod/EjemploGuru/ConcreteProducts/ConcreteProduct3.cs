using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EjemploGuru.ConcreteProducts
{
    internal class ConcreteProduct3 : IProduct
    {
        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("creado3");
        }
    }
}
