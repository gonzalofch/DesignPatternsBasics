using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.ConcreteNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO.ConcreteCreators
{
    public class ConcretePushCreator : INotificationCreator
    {
        public ConcretePushNotification CreateNotification()
        {
            return new ConcretePushNotification();
        }
    }
}
