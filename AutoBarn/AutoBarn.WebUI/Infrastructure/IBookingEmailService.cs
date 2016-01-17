namespace AutoBarn.WebUI.Infrastructure
{
    public interface IBookingEmailService
    {
        void SetHtmlString(string htmlPath);
        void SetPlaceholders(int bookingId, string name, string registrationm, string date, string notes);
        void CreateMessage(string email);
        void SendEmail();
    }
}