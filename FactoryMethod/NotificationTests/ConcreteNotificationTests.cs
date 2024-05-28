using FactoryMethod.EJEMPLO.ConcreteCreators;
using FluentAssertions;
using FactoryMethod.EJEMPLO;
using FactoryMethod.EJEMPLO.Enum;
namespace NotificationTests
{
    public class ConcreteNotificationTests
    {
        

        [Fact]
        public void Should_Be_Next_Email_Notification()
        {
            Notification emailNotification = new Notification
            {
                Title = "Weekly Report",
                Message = "Your weekly report is ready. Please review it.",
                Importance = Importance.Medium,
                SentAt = DateTime.Now
            };
            var notification = new ConcreteEmailCreator().CreateNotification().Notify(emailNotification);
            notification.Should().Be("");  
        }

        [Fact]
        public void Should_Be_Next_SMS_Notification()
        {
            Notification emailNotification = new Notification
            {
                Title = "Weekly Report",
                Message = "Your weekly report is ready. Please review it.",
                Importance = Importance.Medium,
                SentAt = DateTime.Now
            };
            var notification = new ConcreteSMSCreator().CreateNotification().Notify(emailNotification);
            notification.Should().Be("");
        }
        [Fact]
        public void Should_Be_Next_Push_Notification()
        {
            Notification emailNotification = new Notification
            {
                Title = "Weekly Report",
                Message = "Your weekly report is ready. Please review it.",
                Importance = Importance.Medium,
                SentAt = DateTime.Now
            };
            var notification = new ConcretePushCreator().CreateNotification().Notify(emailNotification);
            notification.Should().Be("");
        }
    }
}