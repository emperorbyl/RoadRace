using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class GPSObserver : Observer
    {
        public void Update(Subject s)
        {
            athletesBeingObserved.Sort();
            foreach (var athlete in athletesBeingObserved)
                Console.Write(athlete.bibNumber);
        }
    }
}
