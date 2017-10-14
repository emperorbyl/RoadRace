using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace RoadRace
{
    public class EmailObserver : Observer
    {
        public override void Update(Subject s)
        {

            MailMessage message = new MailMessage("benjaminprupp@gmail.com", "scavender17@gmail.com");
            message.Subject = "Race Update";
            foreach(var athle in athletesBeingObserved)
            {
                message.Body += athle.ToString() + "\n";
            }
            
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            NetworkCredential basics = new NetworkCredential("benjaminprupp", "hijodedios");
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = basics;
            try
            {
                //smtpClient.Send(message);
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
