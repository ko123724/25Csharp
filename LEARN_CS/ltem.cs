using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LEARN_CS
{
    internal class ltem
    {
        [JsonProperty("LABEL")]
        public int LABEL {get; set;}
        [JsonProperty("ITEM NAME")]
        public string ITEMNAME {get; set;}
        [JsonProperty("STAT NAME")]
        public string STATNAME {get; set;}
        [JsonProperty("STAT VALUE")]
        public string STATVALUE {get; set;}

    }
}
