using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AutoBarn.WebUI.Infrastructure
{
    public class Emailer
    {
        private readonly SmtpClient _client;

        public Emailer(string host = "smtp.123-reg.co.uk")
        {
            var booking = new NetworkCredential("booking@autobarnmotorservices.co.uk", "aB19cCd69");
            _client = new SmtpClient(host) {Credentials = booking};
        }

        public void Send(MailMessage message)
        {
            _client.Send(message);
        }
    }

    public class EmailService
    {
        private string _html;
        private readonly Emailer _emailer;
        private MailMessage _message;

        public EmailService(Emailer emailer)
        {
            _emailer = emailer;
        }

        public void SetHtmlString(string htmlPath)
        {
            // Server.MapPath("~/App_Data/uploads/bookingconfirmation.html")

            _html = File.ReadAllText(htmlPath);
        }

        public void SetPlaceholders(string name, string registrationm, string date, string notes)
        {
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