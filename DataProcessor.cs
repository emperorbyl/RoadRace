using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    class DataProcessor : IAthleteUpdateHandler
    {
        public void ProcessUpdate(AthleteUpdate updateMessage)
        {
            // TODO: Do something to process the update message, depending on the concrete type of message
            // TODO: Note that the console write line does below here
            Console.WriteLine(updateMessage.ToString());
        }
    }
}
