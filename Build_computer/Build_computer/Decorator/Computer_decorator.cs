using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using Build_computer.Component;

namespace Build_computer.Decorator
{
  abstract  class Computer_decorator : Computer
    {
        protected Computer computer;
        public Computer_decorator(string name,string combo_result, Computer computer_) : base(name)
        {
            computer= computer_;
        }

      //  abstract public void AddDecorComponent(ComboBox comboBox1);
    }
}
