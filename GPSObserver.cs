using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class GPSObserver : Observer
    {
        public override void Update(Subject s)
        {

            athletesBeingObserved.Sort();
            foreach (var athl in athletesBeingObserved)
                Console.Write(athl.bibNumber.ToString() + "\n");
        }
    }
}
