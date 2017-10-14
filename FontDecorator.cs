using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadRace
{
    public class FontDecorator : ListObserverDecorator
    {
        public void ChangeFont(object sender)
        {
            if (decoratedList.font == "Times New Roman")
                decoratedList.font = "Glyphic Serifs";
            else
                decoratedList.font = "Times New Roman";
        }
    }
}
