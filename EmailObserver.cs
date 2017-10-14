using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace RoadRace
{
    public class EmailObserver : Observer
    {
        public void Update(Subject s)
        {
            MailMessage message = new MailMessage("benjaminprupp@gmail.com", "scavender17@gmial.com");
            message.Subject = "Race Update";
            foreach(var athlete in athletesBeingObserved)
            {
                message.Body += athlete.ToString() + "\n";
            }
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Send(message);
        }
    }
}
