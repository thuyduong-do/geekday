using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thelastteam_geekday_2020.Models
{
    public class Player
    {
        public int UnitId { get; set; }
        public string Action { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetId { get; set; }
    }
}