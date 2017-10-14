using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    interface IRaceDataSource
    {
        string InputFilename { get; set; }
        IAthleteUpdateHandler Handler { get; set; }
        int SleepTimeForSimulatedSecond { get; set; }

        void Start();
        void Stop();
    }
}
