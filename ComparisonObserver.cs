using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    class ComparisonObserver : Observer
    {
        private Athlete athlete;
        private Athlete athlete1;
        public override void Update(Subject s)
        {
            athlete = athletesBeingObserved[0];
            athlete1 = athletesBeingObserved[1];
            Console.Write(athlete.bibNumber.ToString() + " "+ athlete.regProf.firstName + athlete.regProf.lastName + athlete.regProf.gender + athlete.regProf.age.ToString() + "\n");
            Console.Write(athlete1.bibNumber.ToString() + " "+ athlete1.regProf.firstName + athlete1.regProf.lastName + athlete1.regProf.gender + athlete1.regProf.age.ToString() + "\n");            
        }
    }
}
