using AutoBarn.WebUI.Models;

namespace AutoBarn.WebUI.Infrastructure
{
    public interface IContactEmailService
    {
        void CreateMessage(ContactViewModel contact);
        void SendEmail();
    }
}