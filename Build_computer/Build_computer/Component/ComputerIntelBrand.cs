﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_computer.Component
{
    class ComputerIntelBrand :Computer
    {
       // public int Result { get; set; }
        public ComputerIntelBrand() : base("Компьютер Intel")
        {

        }
        public override int GetCost(string result)
        {
            return 0;
        }
    }
}
