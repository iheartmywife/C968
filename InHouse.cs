﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kChermak_PA
{
    public class InHouse : Part
    {
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
        public int MachineID { get; set; }
    }
}
