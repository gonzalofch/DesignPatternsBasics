using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.EJEMPLO;

namespace FactoryMethod.EJEMPLO.ConcreteNotifications
{
    public class ConcreteEmailNotification : INotification
    {
        public string Notify(Notification notification)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("*************************************");
            sb.AppendLine($"Title: {notification.Title}");
            sb.AppendLine($"Sent At: {notification.SentAt.ToString("yyyy-MM-dd HH:mm:ss")}");
            sb.AppendLine($"Importance: {notification.Importance}");
            sb.AppendLine("*************************************");
            sb.AppendLine();
            sb.AppendLine(notification.Message);
            sb.AppendLine();
            sb.AppendLine("*************************************");

            return sb.ToString();
        }
    }
}
