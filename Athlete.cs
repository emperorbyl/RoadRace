using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class Athlete : Subject
    {
        public int bibNumber { get; set; }
        public RegistrationProfile regProf = new RegistrationProfile();
        public Athlete(int bib, RegistrationProfile regProg)
        {
            bibNumber = bib;
            regProf = regProg;
        }
        public Athlete()
        { }
    }
}
