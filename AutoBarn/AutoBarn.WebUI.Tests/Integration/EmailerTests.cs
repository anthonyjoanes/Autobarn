using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoBarn.WebUI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AutoBarn.WebUI.Tests.Integration
{
    [TestClass]
    public class EmailerTests
    {
        [TestMethod]
        public void Send_ShouldSendEmail_StandardCall()
        {
            var emailer = new Emailer();

            var message = new MailMessageBuilder()
                .WithFromAddress("booking@autobarnmotorservices.co.uk")
                .WithToAddress("anthonyjoanes@gmail.com")
                .WithSubject("TESTing")
                .WithMessageBody("This is some body text")
                .Build();

            emailer.Send(message);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Send_ShouldSendHTMLFormatEmail()
        {
            var html = @"<h1>AUTO-BARN</h1>
                        <h3>02392 592010</h3>
                        <h3>BOOKING CONFIRMATION</h3>
                        <hr/>
                        <p>Dear %FIRSTNAME%</p>
                        <p>Your vehicle reg: %REGISTRATION% has successfully been booked in at the Auto-Barn on %BOOKINGDATE%</p>
                        <p>Someone will call you back shortly. If you have any questions you can call us or email at <a href='mailto:info@autobarnmotorservices.co.uk'>info@autobarnmotorservices.co.uk</a></p>
                        <p>Remember, main dealer standards at a fraction of the cost!</p>
                        <p>See you soon</p>
                        <p>Yours Sincerely</p>
                        <p>The Auto-Barn team.</p>";

            html = html.Replace("%FIRSTNAME%", "Anthony");
            html = html.Replace("%REGISTRATION%", "HW10 HNT");
            html = html.Replace("%BOOKINGDATE%", DateTime.Now.ToLongDateString());

            var emailer = new Emailer();

            var message = new MailMessageBuilder()
               .WithFromAddress("booking@autobarnmotorservices.co.uk")
               .WithToAddress("anthonyjoanes@gmail.com")
               .WithSubject("TESTing")
               .WithMessageBody(html)
               .Build();

            emailer.Send(message);

            Assert.IsTrue(true);
        }
    }
}
