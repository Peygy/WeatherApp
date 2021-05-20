using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WeatherOutput
{
    class weather
    {
        [JsonInclude]
        public _0 _0;

        public weather()
        {
            _0 = new _0();
        }
    }
}
