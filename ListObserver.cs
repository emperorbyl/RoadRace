using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadRace
{
    public class ListObserver : Observer
    {
        public virtual string font { get; set; }
        public virtual ConsoleColor color { get { return ConsoleColor.White; } set { color = value; } }
        public virtual void Font(Subject s) { }
        public virtual void Color(Subject s) { }
        public override void Update(Subject s)
        {

            foreach (var ath in athletesBeingObserved)
            {
                Console.Write(ath.bibNumber.ToString() + " " + ath.regProf.firstName + ath.regProf.lastName + ath.regProf.gender + ath.regProf.age.ToString(), font, color);
                
            }
        }
    }
}
