using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thelastteam_geekday_2020.Models
{
    public class Data
    {
        [JsonProperty("you_are")]
        public int ID { get; set; }
        [JsonProperty("your_units")]
        public int[] Units { get; set; }
        [JsonProperty("your_unitdatas")]
        public UnitData[] UnitDatas { get; set; }
        [JsonProperty("you_see")]
        public Item[] Items { get; set; }

        public string message { get; set; }
    }
}