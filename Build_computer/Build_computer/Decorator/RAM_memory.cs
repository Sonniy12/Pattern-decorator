using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Build_computer.Component;
using Build_computer.Decorator;

namespace Build_computer.Decorator
{
    class RAM_memory : Computer_decorator
    {

       public RAM_memory(Computer computer, string result_comb):base(computer.Name, "\n" + result_comb + "\n", computer)
        {

        }

        public override int GetCost( string result)
        {
            if (result=="Оперативная память на 2ГБ")
            {
                return computer.GetCost(result) + 2000;
            }
            else if (result == "Оперативная память на 4ГБ")
            {
                return computer.GetCost(result) + 4000;
            }
            else if (result == "Оперативная память на 8ГБ")
            {
                return  computer.GetCost(result) + 6000;
            }
            else if (result == "Оперативная память на 16ГБ")
            {
                return computer.GetCost(result) + 8000;
            }
            else if (result == "Оперативная память на 32ГБ")
            {
                return computer.GetCost(result) + 10000;
            }
            else
            {
                return computer.GetCost("  No RAM_memory  ");
            }
           
        }
    }
}
