using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Motherboard : Computer_decorator
    {
        public Motherboard(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "AMD Gigabyte B450 AORUS Elite V2")
            {
                return computer.GetCost(result) + 8420;
            }
            else if (result == "AMD MSI B450 TOMAHAWK MAX II")
            {
                return computer.GetCost(result) + 9600;
            }
            else if (result == "Intel ASUS PRIME H310M-R R2.0")
            {
                return computer.GetCost(result) + 3770;
            }
            else if (result == "Intel ASROCK B460M Pro4 ")
            {
                return computer.GetCost(result) + 7290;
            }

            else
            {
                return computer.GetCost("  No Motherboard  ");
            }

        }
    }
}
