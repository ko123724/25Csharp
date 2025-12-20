using Newtonsoft.Json;
    public class Root
    {
        [JsonProperty("LABEL ")]
        public object LABEL { get; set; }

        [JsonProperty("ITEM NAME")]
        public string ITEMNAME { get; set; }

        [JsonProperty("STAT NAME")]
        public string STATNAME { get; set; }

        [JsonProperty("STAT VALUE")]
        public object STATVALUE { get; set; }

        [JsonProperty("PRICE")]
        public object PRICE { get; set; }

    }
