using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherOutput
{
    [Serializable]
    class CityInfo
    {
        sys Sys;
        weather Weather;
        main Main;

        public CityInfo()
        {
            Sys = new sys();
            Weather = new weather();
            Main = new main();
        }

        public string name { get; set; }
        public int id { get; set; }

        public void WeatherOutput() //Ввод города и вывод погоды для этого города
        {            
            Console.WriteLine($"Город: {name}, Страна: {Sys.country}, Температура: {Main.temp}, Погода: {Weather.main}, {Weather.description}");
        }
    }
}
