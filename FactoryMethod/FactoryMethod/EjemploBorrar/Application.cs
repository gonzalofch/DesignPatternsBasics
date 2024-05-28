using FactoryMethod.EJEMPLO.ConcreteCreators;
using FactoryMethod.EJEMPLO.Enum;

namespace FactoryMethod.EJEMPLO
{
    public class Application
    {
        public string ExecuteSender(User user, Notification data)
        {

            if (user.Preference == UserPreferences.Email)
            {
                var notification = new ConcreteEmailCreator().CreateNotification().Notify(data);
            }
            else if (user.Preference == UserPreferences.SMS)
            {
                var notification = new ConcreteSMSCreator().CreateNotification().Notify(data);
            }
            else if (user.Preference == UserPreferences.PushNotifications)
            {
                var notification = new ConcreteEmailCreator().CreateNotification().Notify(data);
            }
            else
            {
                throw new Exception("Unkown");
            }
            return "mensaje";
        }
    }
}
