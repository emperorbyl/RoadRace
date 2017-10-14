using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class ListObserverDecorator : ListObserver
    {
        public ListObserver decoratedList { get; set; }
        public override string font { get { return decoratedList.font; } set { decoratedList.font = value; } }
        public override ConsoleColor color { get { return decoratedList.color; } set { decoratedList.color = value; } }
        public override void Update(Subject s)
        {
            decoratedList.Update(s);
        }
    }
}
