﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser.DTO
{
    public class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;

        public StateCodeDAO(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}
