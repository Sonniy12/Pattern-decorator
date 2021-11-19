using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Video_card : Computer_decorator
    {
        public Video_card(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "AMD Radeon RX Vega 56")
            {
                return computer.GetCost(result) + 12000;
            }
            else if (result == "AMD Radeon R9 Fury")
            {
                return computer.GetCost(result) + 16000;
            }
            else if (result == "Intel Xe HPG")
            {
                return computer.GetCost(result) + 30000;
            }
            else if (result == "Intel UHD Graphics 630 ")
            {
                return computer.GetCost(result) +26000;
            }
           
            else
            {
                return computer.GetCost("  No Video card  ");
            }

        }
    }
}
