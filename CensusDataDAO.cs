﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public long population;
        public long area;
        public long density;

        public CensusDataDAO(string state, long population, long area, long density)
        {
            this.state = state;
            this.population =Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }
    }
}
