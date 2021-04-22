using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherOutput
{
    [Serializable]
    class ObjectInfo
    {
        public string City { get; set; }
        public string Weather { get; set; } //поставил string, т.к не думаю, что будет только температура 

        public ObjectInfo()
        {

        }
    }
}
