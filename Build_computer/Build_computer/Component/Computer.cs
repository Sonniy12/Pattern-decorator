using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_computer.Component
{
  abstract  class Computer
    {
       // public int Result { get;  set; }
        public string Name { get; protected set; }
        public Computer(string name)
        {
            Name = name;
        }
        abstract public int GetCost( string result);
    }
}
