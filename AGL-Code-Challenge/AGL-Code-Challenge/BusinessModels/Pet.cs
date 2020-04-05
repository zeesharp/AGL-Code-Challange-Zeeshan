using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AGL_Code_Challenge.BusinessModels.Enum;

namespace AGL_Code_Challenge.BusinessModels
{
    public class Pet
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public string Type { get; set; }
        //public AnimalEnum Type { get; set; }       
    }
}
