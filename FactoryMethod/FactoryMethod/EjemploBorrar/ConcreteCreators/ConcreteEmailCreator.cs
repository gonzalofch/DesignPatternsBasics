using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.ConcreteNotifications;
using FactoryMethod.EJEMPLO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO.ConcreteCreators
{
    public class ConcreteEmailCreator : INotificationCreator
    {
        public ConcreteEmailNotification CreateNotification()
        {
            return new ConcreteEmailNotification();
        }
    }
}
