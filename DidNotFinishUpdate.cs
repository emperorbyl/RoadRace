﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadRace
{
    public class DidNotFinishUpdate : AthleteUpdate
    {
        public DidNotFinishUpdate() : base(AthleteRaceStatus.DidNotFinish) { }

        public DidNotFinishUpdate(string[] properties) : base(AthleteRaceStatus.DidNotFinish, properties)
        {
            if (properties.Length != 3 || properties[0] != AthleteRaceStatus.DidNotFinish.ToString())
                throw new ApplicationException("Invalid properties");
        }
    }
}
