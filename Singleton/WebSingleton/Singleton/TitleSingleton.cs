using WebSingleton.Models;

namespace WebSingleton.Singleton;

public class TitleSingleton
{
    private static TitleSingleton _instance = null;
    public string title1 = "";
    public string title2 = "";
    public string title3 = "";

    public TitleSingleton()
    {
        using (Models.MyDbContext db = new MyDbContext())
        {
            var titles = db.Titles.ToList();
            title1 = titles.Where(d => d.Id == 1).First().Text;
            title2 = titles.Where(d => d.Id == 2).First().Text;
            title3 = titles.Where(d => d.Id == 3).First().Text;
        }
    }

    public static TitleSingleton Instance
    {
        get
        {
            if (_instance==null)
            {
                _instance = new TitleSingleton();
            }

            return _instance;
        }
    }
}