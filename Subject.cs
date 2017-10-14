using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class Subject
    {
        private readonly object _myLock = new object();
        private readonly List<Observer> _subscribers = new List<Observer>();
        public List<Observer> Subscribers { get { return _subscribers; } }
        public void Subscribe(Observer observer)
        {
            lock (_myLock)
            {
                if (observer != null && !_subscribers.Contains(observer))
                    _subscribers.Add(observer);
            }
        }
        public void Unsubscribe(Observer observer)
        {
            lock (_myLock)
            {
                if (_subscribers.Contains(observer))
                    _subscribers.Remove(observer);
            }
        }
        protected void Notify()
        {
            lock (_myLock)
            {
                foreach (Observer observer in _subscribers)
                    observer.Update(Clone());
            }
        }
        public virtual Subject Clone()
        {
            return MemberwiseClone() as Subject;
        }
    }
}
