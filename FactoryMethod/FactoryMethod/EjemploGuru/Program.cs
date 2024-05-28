using FactoryMethod.EjemploGuru.ConcreteCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EjemploGuru
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProduct p1 = new ConcreteCreator1().FactoryMethod();
            IProduct p2 = new ConcreteCreator1().FactoryMethod();
            IProduct p3 = new ConcreteCreator1().FactoryMethod();
            p1.DoSomething();
            p2.DoSomething();
            p3.DoSomething();
        }

    }
}
