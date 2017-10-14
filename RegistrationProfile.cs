using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class RegistrationProfile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public RegistrationProfile()
        {
            firstName = "";
            lastName = "";
            gender = "";
            age = 0;
        }
    }
}
