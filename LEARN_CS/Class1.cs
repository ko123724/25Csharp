using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARN_CS
{
    internal class Class1
    {
        [JsonProperty("LABEL")]
        public int LABEL { get; set; }
        
        [JsonProperty("ITEM NAME")]
        public string ITEMNAME { get; set; }

        [JsonProperty("STAT NAME")]
        public string STATNAME { get; set; }
        [JsonProperty("STAT VALUE")]
        public string STATVALUE { get; set; }

        [JsonProperty("Rating")]
        public string Rating { get; set; }

        [JsonProperty("ID")]
        public string ID { get; set; }


    } 
}
