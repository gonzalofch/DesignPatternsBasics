using Adapter.Interface;

namespace Adapter;

public class EmailAdapter : IEmailer
{
    private IEmailer2 _emailProvider;

    public EmailAdapter()
    {
        _emailProvider = new EmailProvider2();
    }

    public void Send()
    {
        this._emailProvider.SendEmail();
    }
}