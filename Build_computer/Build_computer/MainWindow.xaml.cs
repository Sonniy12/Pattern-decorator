using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Build_computer.Component;
using Build_computer.Decorator;
namespace Build_computer
{
    /// <summary>
    /// Паттерн Декоратор
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string result_combo = "";
        int Result = 0;
        Computer Computer1;
        Computer Computer2;
        Add_componentCombobox obj;
        public MainWindow()
        {
            InitializeComponent();
            obj = new Add_componentCombobox();
            Computer1 = new ComputerAMDBrand();
            Computer2=new ComputerIntelBrand();
            //1
            obj.Add_Ram(_cb_1);
            obj.Add_hard(_cb_2);
            obj.Add_mother(_cb_3);
            obj.Add_video(_cb_4);
            obj.Add_proc(_cb_5);
            obj.Add_OS(_cb_6);
            obj.Add_sound(_cb_7);
            //2
            obj.Add_screen(_cb_8);
            obj.Add_keyboard(_cb_9);
            obj.Add_mouse(_cb_10);
            

        }

        private void _cb_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_1.SelectedItem.ToString();
        }

        private void _cb_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           result_combo = _cb_2.SelectedItem.ToString();

        }

        private void _cb_3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_3.SelectedItem.ToString();
        }

        private void _cb_4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_4.SelectedItem.ToString();
        }

        private void _cb_5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_5.SelectedItem.ToString();
        }

        private void _cb_6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_6.SelectedItem.ToString();
        }
        private void _cb_7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_7.SelectedItem.ToString();
        }
        private void _cb_8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_8.SelectedItem.ToString();
        }

        private void _cb_9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_9.SelectedItem.ToString();
        }

        private void _cb_10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            result_combo = _cb_10.SelectedItem.ToString();
        }
        //button_click AMD

        private void Add_Ram_Click(object sender, RoutedEventArgs e) //Ram
        {
            if (result_combo != "")
            {
                
                Computer1 = new RAM_memory(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Ram " + result_combo +":" + Computer1.GetCost(result_combo).ToString()+ " Итого: "+ Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new RAM_memory(Computer1, result_combo); Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет " + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Hard_Click(object sender, RoutedEventArgs e)//Жесткий диск
        {
            if (result_combo!="")
            {
                Computer1 = new Hard_drive(Computer1, result_combo); Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Жесткий диск " + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Hard_drive(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет " + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
           
        }

        private void Add_Mother_Click(object sender, RoutedEventArgs e)// Материнская плата
        {
            if (result_combo != "")
            {
                Computer1 = new Motherboard(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Материнская плата" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Motherboard(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Video_Click(object sender, RoutedEventArgs e)//Видео карта
        {
            if (result_combo != "")
            {
                Computer1 = new Video_card(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Видео карта" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Video_card(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Proc_Click(object sender, RoutedEventArgs e)//Процессор
        {
            if (result_combo != "")
            {
                Computer1 = new Processor_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Процессор" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Processor_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_OS_Click(object sender, RoutedEventArgs e)//ОС 
        {
            if (result_combo != "")
            {
                Computer1 = new OS(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "ОС" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new OS(Computer1, result_combo); Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Sound_Click(object sender, RoutedEventArgs e)//Звуковая карта 
        {
            if (result_combo != "")
            {
                Computer1 = new Sound_card(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Звуковая карта" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Sound_card(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }
        //_list2
        private void Add_Screen_Click(object sender, RoutedEventArgs e)//Монитор
        {
            if (result_combo != "")
            {
                Computer1 = new Screen(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Монитор -" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Screen(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Keyboard_Click(object sender, RoutedEventArgs e)//Клавиатура
        {
            if (result_combo != "")
            {
                Computer1 = new Keyboard_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Клавиатура -" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Keyboard_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Add_Mouse_Click(object sender, RoutedEventArgs e)//Мышь
        {
            if (result_combo != "")
            {
                Computer1 = new Mouse_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Мышь -" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
            else
            {
                Computer1 = new Mouse_(Computer1, result_combo);
                Result += Computer1.GetCost(result_combo);
                _list2.Items.Add(Computer1.Name + " +  " + "Нет" + result_combo + ":" + Computer1.GetCost(result_combo).ToString() + " Итого: " + Result);
                result_combo = "";
            }
        }

        private void Clear_list_Click(object sender, RoutedEventArgs e)
        {
            _list.Items.Clear();
            Result = 0;
        }

        private void Clear_list2_Click(object sender, RoutedEventArgs e)
        {
            _list2.Items.Clear();
            Result = 0;
        }
    }
}
