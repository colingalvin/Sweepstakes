using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace MySweepstakes
{
    public class Winner : Participant
    {
        // member variables

        // constructor
        public Winner(Participant chosenWinner)
        {
            firstName = chosenWinner.firstName;
            lastName = chosenWinner.lastName;
            emailAddress = chosenWinner.emailAddress;
            registrationNumber = chosenWinner.registrationNumber;
        }

        // member methods
        public override void Notify(string sweepstakesName, Winner winner)
        {
            Console.WriteLine($"Congratulations {winner.firstName}, you have been chosen as our winner!");
            SendEmail(sweepstakesName, winner);
        }

        private void SendEmail(string sweepstakesName, Winner winner)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sweepstakes Manager", "MarketingFirm@marketingfirm.com"));
            message.To.Add(new MailboxAddress($"{winner.firstName} {winner.lastName}", $"{winner.emailAddress}"));
            message.Subject = "Congratulations!";

            message.Body = new TextPart("plain")
            {
                Text = $@"Dear {winner.firstName} {winner.lastName},

                We are pleased to inform you that you have been selected as the winner of our {sweepstakesName} sweepstakes!
                Please contact us at your earliest convenience for information on how to collect your prize.

                Sincerely,
                Colin Galvin, Sweepstakes Manager"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("email", "password");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
