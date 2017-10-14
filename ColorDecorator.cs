using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    class ColorDecorator : ListObserverDecorator
    {
        private void ChangeColor(object sender)
        {
            if (decoratedList.color == ConsoleColor.White)
                decoratedList.color = ConsoleColor.Yellow;
            else
                decoratedList.color = ConsoleColor.Blue;
        }
    }
}
