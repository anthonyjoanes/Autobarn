using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AutoBarn.WebUI.Services
{
    public class Emailer : IEmailer
    {
        private readonly SmtpClient _client;

        public Emailer(string host = "smtp.123-reg.co.uk")
        {
            var booking = new NetworkCredential("booking@autobarnmotorservices.co.uk", "aB19cCd69!");
            _client = new SmtpClient(host) {Credentials = booking};
        }

        public void Send(MailMessage message)
        {
            _client.Send(message);
        }
    }
}
