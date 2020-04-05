using AGL_Code_Challenge.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL_Code_Challenge
{
    public static class BusinessLogic
    {
        public static List<Pet> GetCatsNameByGender(List<People> data, string gender, string animalType)
        {
            var list = new List<Pet>();
            list = data.Where(s => s.Gender == gender && s.Pets != null).SelectMany(s => s.Pets.FindAll(a => a.Type == animalType)).ToList();
            return list;
        }

    }
}
