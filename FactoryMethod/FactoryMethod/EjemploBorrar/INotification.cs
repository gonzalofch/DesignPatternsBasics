using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO
{
    public interface INotification
    {
        public string Notify(Notification notification)
        {
            return notification.Message;
        }
    }
}
