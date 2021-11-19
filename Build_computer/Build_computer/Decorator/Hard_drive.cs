using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer.Decorator
{
    class Hard_drive :Computer_decorator
    {
        public Hard_drive(Computer computer, string result_comb) : base(computer.Name, "\n" + result_comb + "\n", computer)
    {

    }

    public override int GetCost(string result)
    {
        if (result == "AMD  Radeon R5M480G8 480ГБ")
        {
            return computer.GetCost(result) + 6290;
        }
        else if (result == "AMD TOSHIBA P300 HDWD110UZSVA 1TB")
        {
            return computer.GetCost(result) + 2790;
        }
        else if (result == "Intel WD Blue HDD-WD20EZAZ 2TB")
        {
            return computer.GetCost(result) + 4490;
        }
        else if (result == "Intel DC D3-S4610 SSD-960ГБ")
        {
            return computer.GetCost(result) + 24820;
        }

        else
        {
            return computer.GetCost("  No Hard drive  ");
        }

    }
}
}
