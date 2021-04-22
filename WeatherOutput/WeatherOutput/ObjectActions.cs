using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace WeatherOutput
{
    class ObjectActions
    {
        public void Serializing(string path, ObjectInfo weatherObj)
        {
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.Write(JsonSerializer.Serialize(weatherObj));
            }
        }


        public ObjectInfo Deserializing(string path)
        {
            ObjectInfo weatherObj;
            using (StreamReader stream = new StreamReader(path))
            {
                weatherObj = JsonSerializer.Deserialize<ObjectInfo>(stream.ReadToEnd());
            }

            return weatherObj;
        }
    }
}
