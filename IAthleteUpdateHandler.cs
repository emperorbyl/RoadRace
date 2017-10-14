using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public interface IAthleteUpdateHandler
    {
        void ProcessUpdate(AthleteUpdate updateMessage);
    }
}
