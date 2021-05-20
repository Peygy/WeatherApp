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
            string result;
            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=2b97cac807e74b40cbd789b3ab8866c4");
            WebResponse response = request.GetResponse();

            using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }

            CityInfo menu = JsonSerializer.Deserialize<CityInfo>(result);

            return menu;
        }

        public void WeatherInput()
        {
            CityInfo info = new CityInfo();
            Console.Write("Название города (на англ. языке):  ");
            info = WebDataTransfer(Console.ReadLine());
            Console.WriteLine();
            info.WeatherOutput();
        }
    }
}
