namespace AutoBarn.WebUI.Services
{
    public interface IBookingEmailService
    {
        void SetHtmlString(string htmlPath);
        void SetPlaceholders(int bookingId, string name, string registrationm, string date, string notes);
        void CreateMessage(string email);
        void CreateAutoBarnMessage(string firstname, string lastname, string email, string telehpone);
        void SendEmail();
    }
}