using System.Net.Mail;

namespace AutoBarn.WebUI.Infrastructure
{
    public class MailMessageBuilder
    {
        private readonly MailMessage _message;

        public MailMessageBuilder()
        {
            _message = new MailMessage {IsBodyHtml = true};
        }

        public MailMessageBuilder WithSubject(string subject)
        {
            _message.Subject = subject;
            return this;
        }

        public MailMessageBuilder WithMessageBody(string messageBody)
        {
            _message.Body = messageBody;
            return this;
        }

        public MailMessageBuilder WithFromAddress(string fromAddress)
        {
            _message.From = new MailAddress(fromAddress);
            return this;
        }

        public MailMessageBuilder WithToAddress(string toAddress)
        {
            _message.To.Add(toAddress);
            return this;
        }

        public MailMessage Build()
        {
            return _message;
        }
    }
}