using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.EJEMPLO.Enum;

namespace FactoryMethod.EJEMPLO
{
    public class Notification
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Importance Importance { get; set; }
        public DateTime SentAt { get; set; }

        public Notification()
        {

        }

        public Notification(string title, string message, Importance importance, DateTime sentAt)
        {
            Title = title;
            Message = message;
            Importance = importance;
            SentAt = sentAt;
        }
    }
}