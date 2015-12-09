using System.Net.Mail;

namespace AutoBarn.WebUI.Infrastructure
{
    public interface IEmailer
    {
        void Send(MailMessage message);
    }
}