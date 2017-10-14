using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SimulatorController controller = new SimulatorController();
            controller.Run("../../../Short Race Simulation-01.txt");
        }
    }
}
