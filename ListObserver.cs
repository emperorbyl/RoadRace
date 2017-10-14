using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadRace
{
    class ListObserver : Observer
    {
        public virtual string font { get; set; }
        public virtual ConsoleColor color { get; set; }
        public virtual void Update(Subject s)
        {
            foreach (var athlete in athletesBeingObserved)
            {
                Console.Write(athlete.ToString(), font, color);
                
            }
        }
    }
}
