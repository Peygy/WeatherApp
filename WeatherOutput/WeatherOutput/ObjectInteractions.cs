using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherOutput
{
    class ObjectInteractions
    {
        ObjectInfo info;
        ObjectActions actions;
        sys Sys;
        weather Weather;
        main Main;

        public ObjectInteractions()
        {
            info = new ObjectInfo();
            actions = new ObjectActions();
            Sys = new sys();
            Weather = new weather();
            Main = new main();
        }

        public void Menu()
        {
            int input = 0;
            while (input != 2)
            {
                Console.Clear();
                Console.WriteLine("1.Узнать погоду");
                Console.WriteLine("2.Выйти из меню");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write($"Выберите пункт: ");
                int.TryParse(Console.ReadLine(), out input);


                switch (input)
                {
                    case 1:
                        {
                            Console.Clear();
                            WeatherInput();
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Выберите номер из меню! Нажмите Enter...");
                            Console.ReadLine();
                            break;
                        }
                }
            }          
        }


        public void WeatherInput() //Ввод города и вывод погоды для этого города
        {
            Console.Write("Название города (на англ. языке):  ");
            actions.WebDataTransfer(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Город: {info.name}, Страна: {Sys.country}, Температура: {Main.temp}, Погода: {Weather.main}, {Weather.description}");
        }
    }
}
