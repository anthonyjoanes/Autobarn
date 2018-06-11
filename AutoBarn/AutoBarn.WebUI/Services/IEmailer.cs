using System.Net.Mail;

namespace AutoBarn.WebUI.Services
{
    public interface IEmailer
    {
        void Send(MailMessage message);
    }
}