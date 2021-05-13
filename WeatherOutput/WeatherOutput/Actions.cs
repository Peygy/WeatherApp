using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net;

namespace WeatherOutput
{
    class Actions
    {        
        public CityInfo WebDataTransfer(string city)
        {
            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=2b97cac807e74b40cbd789b3ab8866c4");
            WebResponse response = request.GetResponse();

            CityInfo menu = JsonSerializer.Deserialize<CityInfo>(new StreamReader(response.GetResponseStream()).ReadLine());

            return menu;
        }

        public void WeatherInput()
        {
            CityInfo info = new CityInfo();
            Console.Write("Название города (на англ. языке):  ");
            WebDataTransfer(Console.ReadLine());
            Console.WriteLine();
            info.WeatherOutput();
        }
    }
}
