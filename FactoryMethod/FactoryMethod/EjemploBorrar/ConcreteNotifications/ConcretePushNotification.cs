using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO.ConcreteNotifications
{
    public class ConcretePushNotification : INotification
    {
        public string Notify(Notification notification)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append(notification.Title + ": ");
            sb.AppendLine();
            sb.Append(notification.Message);
            sb.AppendLine();
            if (notification.Importance == Importance.VeryImportant || notification.Importance == Importance.Important)
            {
                sb.Append(" (Important)");
            }

            return sb.ToString();
        }
    }
}
