using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Screen : Computer_decorator
    {
        public Screen(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "Монитор игровой ASUS Gaming VA24EHE 23.8 черный")
            {
                return computer.GetCost(result) + 9980;
            }
            else if (result == "Монитор игровой SAMSUNG C24RG50FQI 23.5 черный")
            {
                return computer.GetCost(result) + 13770;
            }
            else if (result == "Монитор игровой AOC Gaming G2590FX 24.5 красный")
            {
                return computer.GetCost(result) + 17990;
            }
            else if (result == "Монитор игровой BENQ Zowie XL2411P 24 серый")
            {
                return computer.GetCost(result) + 16200;
            }

            else
            {
                return computer.GetCost("  No Screen ")+0;
            }

        }
    }
}
