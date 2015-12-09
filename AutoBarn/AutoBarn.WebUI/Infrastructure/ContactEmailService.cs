using System;
using System.Net.Mail;
using AutoBarn.WebUI.Models;

namespace AutoBarn.WebUI.Infrastructure
{
    public class ContactEmailService : IContactEmailService
    {
        private readonly IEmailer _emailer;
        private MailMessage _message;
        private readonly string _notificationEmail;

        public ContactEmailService(IEmailer emailer, string notificationEmail)
        {
            _notificationEmail = notificationEmail;
            _emailer = emailer;
        }

        public void CreateMessage(ContactViewModel contact)
        {
            _message = new MailMessageBuilder()
                .WithFromAddress("contact@autobarnmotorservices.co.uk")
                .WithToAddress(_notificationEmail)
                .WithSubject("Contact form enquiry")
                .WithMessageBody(CreateEmailBody(contact))
                .Build();
        }

        private string CreateEmailBody(ContactViewModel contact)
        {
            var email = @"<h1>Contact Form</h1>
                                <table>
                                    
                                        <tr>
                                            <td>Name</td><td>{0}</td>
                                        </tr>
                                        <tr>
                                            <td>Email</td><td>{1}</td>  
                                        </tr>
                                        <tr>
                                            <td>Telephone</td><td>{2}</td>
                                        </tr>
                                        <tr>
                                            <td>Message</td><td>{3}</td>
                                        </tr>
                                    
                                </table>";

            return string.Format(email, contact.Name, contact.Email, contact.Telephone, contact.Message);
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