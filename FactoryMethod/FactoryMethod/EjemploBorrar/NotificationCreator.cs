using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO
{
    public interface INotificationCreator
    {
        public Notification CreateNotification()
        {
            return new Notification();
        }
    }
}
