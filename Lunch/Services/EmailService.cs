using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
namespace Lunch.Services
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            MimeMessage emailMessage = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Admin", "rakhatali.final@gmail.com");
            emailMessage.From.Add(from);
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.MessageSent += (sender, args) => {
                };
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("rakhatali.final@gmail.com", "Seilkhan123");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);


            }

        }
    }
}