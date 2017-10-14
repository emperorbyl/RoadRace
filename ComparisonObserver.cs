using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    class ComparisonObserver : Observer
    {
        public Athlete athlete { get; set; }
        public Athlete athlete1 { get; set; }
        public void Update(Subject s)
        {
            Console.Write(athlete.bibNumber.ToString() + athlete.regProf.ToString() + "\n");
            Console.Write(athlete1.bibNumber.ToString() + athlete1.regProf.ToString() + "\n");            
        }
    }
}
