using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class OS : Computer_decorator
    {
        public OS(Computer computer, string result_comb) : base(computer.Name,"\n"+ result_comb+ "\n" , computer)
        {

        }

        public override int GetCost(string result)
        {
            if (result == "Microsoft Windows 10 Home")
            {
                return computer.GetCost(result) + 8890;
            }
            else if (result == "Microsoft Windows 10 Professional")
            {
                return computer.GetCost(result) + 14000;
            }
            else if (result == "DOS")
            {
                return computer.GetCost(result) +0;
            }
         

            else
            {
                return computer.GetCost("  No OS  ");
            }

        }
    }
}
