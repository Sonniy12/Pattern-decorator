using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_computer.Component
{
    class ComputerAMDBrand : Computer
    {
      //  public int Result { get; set; }
        public ComputerAMDBrand():base("Компьютер AMD  ")
        {

        }
        public override int GetCost(string result)
        {
            return 0;
        }

      
    }
}
