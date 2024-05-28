using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.ConcreteNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO.ConcreteCreators
{
    public class ConcreteSMSCreator : INotificationCreator
    {
        public ConcreteSMSNotification CreateNotification()
        {
            return new ConcreteSMSNotification();
        }
    }
}
