namespace Singleton.SingletonImplementation;

public class CalendarSingleton
{
    private static CalendarSingleton instance = null;

    private CalendarSingleton()
    {
    }

    public static CalendarSingleton Instance
    {
        get
        {
            if (instance is null)
            {
                instance = new CalendarSingleton();
            }

            return instance;
        }
    }
}