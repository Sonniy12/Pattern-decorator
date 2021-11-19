using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;

namespace Build_computer.Decorator
{
    class Sound_card : Computer_decorator
    {
        public Sound_card(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "Звуковая карта PCI-E CREATIVE Sound Blaster AE-7, 5.1")
            {
                return computer.GetCost(result) + 16890;
            }
            else if (result == "Звуковая карта PCI-E ASUS Strix Soar, 7.1")
            {
                return computer.GetCost(result) + 4770;
            }
            else if (result == "Звуковая карта PCI-E CREATIVE Audigy FX, 5.1")
            {
                return computer.GetCost(result) + 3585;
            }
            else if (result == "Звуковая карта USB EDIFIER GS 02, 1.0")
            {
                return computer.GetCost(result) + 1020;
            }

            else
            {
                return computer.GetCost("  No Sound card ");
            }

        }
    }

}

