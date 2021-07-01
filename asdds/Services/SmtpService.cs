using asdds.Controller;
using asdds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Umbraco.Core.Logging;

namespace asdds.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;

        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }
        public bool sendEmail(ContactViewModel model)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Enquiry from: {model.Name} - {model.Email}";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = (new MailAddress(fromAddress, fromAddress));

                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(SendEmailController), ex, "Error sending contact form");
                return false;
            }
        }

        public bool SendEmail(ContactViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}