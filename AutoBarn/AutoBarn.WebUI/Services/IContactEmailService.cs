using AutoBarn.WebUI.Models;

namespace AutoBarn.WebUI.Services
{
    public interface IContactEmailService
    {
        void CreateMessage(ContactViewModel contact);
        void SendEmail();
    }
}