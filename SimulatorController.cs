﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RoadRace
{
    public class SimulatorController
    {
        private SimulatedDataSource _simluatedData;
        public void Run(string inputFileName)
        {
            IAthleteUpdateHandler handler = new DataProcessor();
            _simluatedData = new SimulatedDataSource()
            {
                InputFilename = inputFileName,
                Handler = handler
            };

            _simluatedData.Start();

            // Let the simulator run for 3 minutes
            Thread.Sleep(18000);

            _simluatedData.Stop();
        }
    }
}
