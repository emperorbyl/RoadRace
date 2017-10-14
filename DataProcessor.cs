using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class DataProcessor : IAthleteUpdateHandler
    {
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            // TODO: Do something to process the update message, depending on the concrete type of message
            // TODO: Note that the console write line does below here
            AthleteUpdate.Create(updateMessage.ToString());
            var fields = updateMessage.ToString().Split(',');
            RegistrationProfile reg = new RegistrationProfile();
            if (fields.Count() == 7)
            {
                reg.firstName = fields[3];
                reg.lastName = fields[4];
                reg.gender = fields[5];
                reg.age = Convert.ToInt16(fields[6]);
            }
            Athlete athlete = new Athlete(updateMessage.BibNumber, reg);
            ListObserver listOb = new ListObserver();
            EmailObserver emailOb = new EmailObserver();
            GPSObserver gpsOb = new GPSObserver();
            ComparisonObserver comparisonOb = new ComparisonObserver();
            if(updateMessage.UpdateType == AthleteRaceStatus.Registered)
                athlete.Subscribe(listOb);
            if (updateMessage.UpdateType == AthleteRaceStatus.Started)
                athlete.Subscribe(gpsOb);
            if (updateMessage.UpdateType == AthleteRaceStatus.OnCourse && athlete.Subscribers.Count > 2)
                athlete.Subscribe(comparisonOb);
            else if (updateMessage.UpdateType == AthleteRaceStatus.OnCourse)
                athlete.Subscribe(emailOb);
            if (updateMessage.UpdateType == AthleteRaceStatus.Finished || updateMessage.UpdateType == AthleteRaceStatus.DidNotFinish)
            {
                athlete.Unsubscribe(listOb);
                athlete.Unsubscribe(emailOb);
                athlete.Unsubscribe(gpsOb);
                athlete.Unsubscribe(comparisonOb);
            }
            foreach (var observer in athlete.Subscribers)
                observer.AddObserver(athlete);
            Console.WriteLine(updateMessage.ToString());
        }
    }
}
