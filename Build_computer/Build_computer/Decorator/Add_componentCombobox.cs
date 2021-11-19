using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace Build_computer.Decorator
{
    class Add_componentCombobox
    {
        public  void Add_proc(ComboBox comboBox1)//5
        {
            comboBox1.Items.Add("AMD  Ryzen 5 3600, OEM");
            comboBox1.Items.Add("AMD AMD Athlon 3000G, OEM");
            comboBox1.Items.Add("Intel Pentium Gold G5420, BOX");
            comboBox1.Items.Add("Intel Core i5 9400F, OEM");
            comboBox1.Items.Add(" ");
        }
        public void Add_hard(ComboBox comboBox1)//2
        {
            comboBox1.Items.Add("AMD  Radeon R5M480G8 480ГБ");
            comboBox1.Items.Add("AMD TOSHIBA P300 HDWD110UZSVA 1TB");
            comboBox1.Items.Add("Intel WD Blue HDD-WD20EZAZ 2TB");
            comboBox1.Items.Add("Intel DC D3-S4610 SSD-960ГБ");
            comboBox1.Items.Add(" ");
        }
        public void Add_mother(ComboBox comboBox1)//3
        {
            comboBox1.Items.Add("AMD Gigabyte B450 AORUS Elite V2");
            comboBox1.Items.Add("AMD MSI B450 TOMAHAWK MAX II");
            comboBox1.Items.Add("Intel ASUS PRIME H310M-R R2.0");
            comboBox1.Items.Add("Intel ASROCK B460M Pro4 ");
            comboBox1.Items.Add("");
        }
        public void Add_OS(ComboBox comboBox1)//6
        {
            comboBox1.Items.Add("Microsoft Windows 10 Home");
            comboBox1.Items.Add("Microsoft Windows 10 Professional");
            comboBox1.Items.Add("DOS");
            comboBox1.Items.Add("");
        }
        public void Add_Ram(ComboBox comboBox1)//1
        {
            comboBox1.Items.Add("Оперативная память на 2ГБ");
            comboBox1.Items.Add("Оперативная память на 4ГБ");
            comboBox1.Items.Add("Оперативная память на 8ГБ");
            comboBox1.Items.Add("Оперативная память на 16ГБ");
            comboBox1.Items.Add("Оперативная память на 32ГБ");
            comboBox1.Items.Add("");
        }
        public void Add_video(ComboBox comboBox1)//4
        {
            comboBox1.Items.Add("AMD Radeon RX Vega 56");
            comboBox1.Items.Add("AMD Radeon R9 Fury");
            comboBox1.Items.Add("Intel Xe HPG");
            comboBox1.Items.Add("Intel UHD Graphics 630 ");
            comboBox1.Items.Add("");
        }
        //Sound_card
        public void Add_sound(ComboBox comboBox1)//7
        {
            comboBox1.Items.Add("Звуковая карта PCI-E CREATIVE Sound Blaster AE-7, 5.1");
            comboBox1.Items.Add("Звуковая карта PCI-E ASUS Strix Soar, 7.1");
            comboBox1.Items.Add("Звуковая карта PCI-E CREATIVE Audigy FX, 5.1");
            comboBox1.Items.Add("Звуковая карта USB EDIFIER GS 02, 1.0");
            comboBox1.Items.Add("");
        }

        public void Add_screen(ComboBox comboBox1)//8
        {
            comboBox1.Items.Add("Монитор игровой ASUS Gaming VA24EHE 23.8 черный");
            comboBox1.Items.Add("Монитор игровой SAMSUNG C24RG50FQI 23.5 черный");
            comboBox1.Items.Add("Монитор игровой AOC Gaming G2590FX 24.5 красный");
            comboBox1.Items.Add("Монитор игровой BENQ Zowie XL2411P 24 серый");
            comboBox1.Items.Add("");
        }
        public void Add_keyboard(ComboBox comboBox1)//9
        {
            comboBox1.Items.Add("Клавиатура A4TECH Bloody B314, USB, c подставкой для запястий");
            comboBox1.Items.Add("Клавиатура OKLICK 505M, USB, белый/черный");
            comboBox1.Items.Add("Клавиатура LOGITECH Multi-Device K380, беспроводная, темно-серый");
            comboBox1.Items.Add("Клавиатура OKLICK 777G PSYCHO, USB");
            comboBox1.Items.Add("");
        }
        public void Add_mouse(ComboBox comboBox1)//10
        {
            comboBox1.Items.Add("Мышь LOGITECH M170, оптическая, беспроводная, USB, серый и черный");
            comboBox1.Items.Add("Мышь A4TECH Bloody V8, игровая, оптическая, проводная, USB, черный");
            comboBox1.Items.Add("Мышь OKLICK 399M STIGMA, игровая, оптическая, проводная, USB, черный");
            comboBox1.Items.Add("Мышь LOGITECH G102 LIGHTSYNC, игровая, оптическая, проводная, USB, белый");
            comboBox1.Items.Add("");
        }
    }
}
