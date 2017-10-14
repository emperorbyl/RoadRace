using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class Observer
    {
        private readonly Dictionary<Int32, Athlete> _athletesBeingObserved = new Dictionary<int, Athlete>();
        private readonly object _myLock = new object();
        protected List<Athlete> athletesBeingObserved { get { return _athletesBeingObserved.Values.ToList(); } }
        public void Update(Subject s)
        {
            Athlete athlete = s as Athlete;
            if (athlete != null)
            {
                lock (_myLock)
                {
                    if (!_athletesBeingObserved.ContainsKey(athlete.bibNumber))
                        _athletesBeingObserved.Add(athlete.bibNumber, athlete);
                    else
                        _athletesBeingObserved[athlete.bibNumber] = athlete;
                }
            }
        }
    }
    
    
}
