using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Keyboard_ : Computer_decorator
    {
        public Keyboard_(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "Клавиатура A4TECH Bloody B314, USB, c подставкой для запястий")
            {
                return computer.GetCost(result) + 2690;
            }
            else if (result == "Клавиатура OKLICK 505M, USB, белый/черный")
            {
                return computer.GetCost(result) + 510;
            }
            else if (result == "Клавиатура LOGITECH Multi-Device K380, беспроводная, темно-серый")
            {
                return computer.GetCost(result) + 3285;
            }
            else if (result == "Клавиатура OKLICK 777G PSYCHO, USB")
            {
                return computer.GetCost(result) + 1220;
            }

            else
            {
                return computer.GetCost(" No Keyboard ") +0;
            }

        }
    }
}
