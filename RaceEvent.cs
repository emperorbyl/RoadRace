using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    class RaceEvent
    {
        public string title { get; set;}
        public DateTime startTime { get; set; }
        public int id { get; set; }
        public Course course { get; set; }
    }
}
