using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.EJEMPLO.ConcreteNotifications
{
    public class ConcreteSMSNotification : INotification
    {
        public string Notify(Notification notification)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append($"[{notification.SentAt.ToString("yyyy-MM-dd HH:mm")}] ");
            sb.Append($"({notification.Importance}) ");
            sb.AppendLine();
            sb.Append(notification.Title + ": ");
            sb.AppendLine();
            sb.Append(notification.Message);

            return sb.ToString();
        }
    }
}
