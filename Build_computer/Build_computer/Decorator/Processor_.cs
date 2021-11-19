using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Processor_:Computer_decorator
    {
        public Processor_(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "AMD  Ryzen 5 3600, OEM")
            {
                return computer.GetCost(result) + 14150;
            }
            else if (result == "AMD AMD Athlon 3000G, OEM")
            {
                return computer.GetCost(result) + 6345;
            }
            else if (result == "Intel Pentium Gold G5420, BOX")
            {
                return computer.GetCost(result) + 10000;
            }
            else if (result == "Intel Core i5 9400F, OEM")
            {
                return computer.GetCost(result) + 12190;
            }

            else
            {
                return computer.GetCost("  No Processor  ");
            }

        }
    }
}
