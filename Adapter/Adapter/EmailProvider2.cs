using Adapter.Interface;

namespace Adapter;

public class EmailProvider2 : IEmailer2
{
    public void SendEmail()
    {
        Console.WriteLine($"Enviar email con mas información desde {this}");
    }
}