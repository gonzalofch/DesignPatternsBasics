using Adapter.Interface;

namespace Adapter;

public class EmailProvider: IEmailer
{
    public void Send()
    {
        Console.WriteLine($"Enviar email desde {this}");
    }
}
