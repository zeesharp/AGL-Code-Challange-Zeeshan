using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static AGL_Code_Challenge.BusinessModels.Enum;
using Newtonsoft.Json.Converters;

namespace AGL_Code_Challenge.BusinessModels
{
    public class People
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "gender")]
         public string Gender { get; set; }
        //[JsonConverter(typeof(StringEnumConverter))]
      //  public GenderEnum Gender { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        [JsonProperty(PropertyName = "pets")]
        public List<Pet> Pets { get; set; }
    }
}
