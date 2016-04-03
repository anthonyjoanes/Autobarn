using System;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace AutoBarn.WebUI.Infrastructure
{
    public class BookingEmailService : IBookingEmailService
    {
        private string _html;
        private readonly IEmailer _emailer;
        private MailMessage _message;
        private MailMessage _autobarnMessage;
        private readonly string _autobarnEmail;

        public BookingEmailService(IEmailer emailer, string autobarnEmail)
        {
            _autobarnEmail = autobarnEmail;
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

        public void CreateAutoBarnMessage(string firstname, string lastname, string email, string telehpone)
        {
            var autoBarnMessage = new StringBuilder();
            autoBarnMessage.Append(string.Format("<p>Name: {0} {1}</p>", firstname, lastname));
            autoBarnMessage.Append(string.Format("<p>Email: {0}</p>", email));
            autoBarnMessage.Append(string.Format("<p>Telephone: {0}</p>", telehpone));
            autoBarnMessage.Append("<hr/>");


            _autobarnMessage = new MailMessageBuilder()
               .WithFromAddress("booking@autobarnmotorservices.co.uk")
               .WithToAddress(_autobarnEmail)
               .WithSubject("NEW BOOKING MADE")
               .WithMessageBody(string.Format("<h4>The following request has just been submitted</h4><hr /><br />{0}{1}"
               , autoBarnMessage, _html))
               .Build();
        }

        public void SendEmail()
        {
            try
            {
                _emailer.Send(_message);
                _emailer.Send(_autobarnMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}