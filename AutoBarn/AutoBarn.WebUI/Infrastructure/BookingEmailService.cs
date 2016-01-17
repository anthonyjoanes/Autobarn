using System;
using System.IO;
using System.Net.Mail;

namespace AutoBarn.WebUI.Infrastructure
{
    public class BookingEmailService : IBookingEmailService
    {
        private string _html;
        private readonly IEmailer _emailer;
        private MailMessage _message;

        public BookingEmailService(IEmailer emailer)
        {
            _emailer = emailer;
        }

        public void SetHtmlString(string htmlPath)
        {
            // Server.MapPath("~/App_Data/uploads/bookingconfirmation.html")

            _html = File.ReadAllText(htmlPath);
        }

        public void SetPlaceholders(int bookingId, string name, string registrationm, string date, string notes)
        {
            _html = _html.Replace("%BOOKINGREF%", bookingId.ToString());
            _html = _html.Replace("%FIRSTNAME%", name);
            _html = _html.Replace("%REGISTRATION%", registrationm);
            _html = _html.Replace("%BOOKINGDATE%", date);
            _html = _html.Replace("%NOTES%", notes);
        }

        public void CreateMessage(string email)
        {
            _message = new MailMessageBuilder()
                .WithFromAddress("booking@autobarnmotorservices.co.uk")
                .WithToAddress(email)
                .WithSubject("AUTO-BARN Booking Confirmation")
                .WithMessageBody(_html)
                .Build();
        }

        public void SendEmail()
        {
            try
            {
                _emailer.Send(_message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}