using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Mouse_ : Computer_decorator
    {
        public Mouse_(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "Мышь LOGITECH M170, оптическая, беспроводная, USB, серый и черный")
            {
                return computer.GetCost(result) + 690;
            }
            else if (result == "Мышь A4TECH Bloody V8, игровая, оптическая, проводная, USB, черный")
            {
                return computer.GetCost(result) + 1340;
            }
            else if (result == "Мышь OKLICK 399M STIGMA, игровая, оптическая, проводная, USB, черный")
            {
                return computer.GetCost(result) + 270;
            }
            else if (result == "Мышь LOGITECH G102 LIGHTSYNC, игровая, оптическая, проводная, USB, белый")
            {
                return computer.GetCost(result) + 2300;
            }

            else
            {
                return computer.GetCost("  No Mouse ");
            }

        }
    }
}
