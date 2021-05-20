using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WeatherOutput
{
    [Serializable]
    class CityInfo
    {
        [JsonInclude]
        public sys sys;

        [JsonInclude]
        public weather weather;

        [JsonInclude]
        public main main;

        public CityInfo()
        {
            sys = new sys();
            weather = new weather();
            main = new main();
        }

        public string name { get; set; }
        public int id { get; set; }

        public void WeatherOutput() //Ввод города и вывод погоды для этого города
        {            
            Console.WriteLine($"Город: {name}, Страна: {sys.country}, Температура: {main.temp}, Погода: {weather._0.main}, {weather._0.description}");
        }
    }
}
