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
    class ObjectActions
    {
        public void WebDataTransfer(string city)
        {
            ObjectInfo general;
            sys Sys;
            weather Weather;
            main Main;

            WebRequest request = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=2b97cac807e74b40cbd789b3ab8866c4");
            WebResponse response = request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while(reader.ReadLine() != null)
                    {
                        general = JsonSerializer.Deserialize<ObjectInfo>(reader.ReadToEnd());
                        Sys = JsonSerializer.Deserialize<sys>(reader.ReadToEnd());
                        Weather = JsonSerializer.Deserialize<weather>(reader.ReadToEnd());
                        Main = JsonSerializer.Deserialize<main>(reader.ReadLine());
                    }
                }
            }
        }
    }
}
