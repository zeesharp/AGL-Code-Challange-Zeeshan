using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using static AGL_Code_Challenge.BusinessModels.Enums;
using Newtonsoft.Json.Converters;

namespace AGL_Code_Challenge.BusinessModels
{
    public class People
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GenderEnum gender  { get; set; }
        [JsonProperty(PropertyName = "pets")]
        public List<Pet> Pets { get; set; }
        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

    }
}
