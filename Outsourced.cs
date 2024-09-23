﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kChermak_PA
{
    public class Outsourced : Part
    {
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
        public string CompanyName { get; set; }
    }
}
