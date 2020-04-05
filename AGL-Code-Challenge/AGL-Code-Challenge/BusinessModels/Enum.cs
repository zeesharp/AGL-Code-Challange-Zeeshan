using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AGL_Code_Challenge.BusinessModels
{
    public static class Enum
    {
        public enum GenderEnum
        {
            [EnumMember(Value = "Male")]
            Male,
            [EnumMember(Value = "Female")]
            Female
        }
        public enum AnimalEnum
        {
            [EnumMember(Value = "Cat")]
            Cat,
            [EnumMember(Value = "Dog")]
            Dog,
            [EnumMember(Value = "Fish")]
            Fish,
            [EnumMember(Value = "Chicken")]
            Chicken
        }
    }
}
