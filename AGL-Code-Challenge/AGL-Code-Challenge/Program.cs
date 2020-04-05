using AGL_Code_Challenge.BusinessModels;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AGL_Code_Challenge.BusinessModels.Enum;

namespace AGL_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetJsonData("http://agl-developer-test.azurewebsites.net/people.json");

           var maleCatList =  BusinessLogic.GetCatsNameByGender(data, GenderEnum.Male.ToString(), AnimalEnum.Cat.ToString());
           var femaleCatList = BusinessLogic.GetCatsNameByGender(data, GenderEnum.Female.ToString(), AnimalEnum.Cat.ToString());

            PrintCatList(data, maleCatList, GenderEnum.Male.ToString());
            PrintCatList(data, femaleCatList, GenderEnum.Female.ToString());


            Console.ReadLine();

        }
        private static void PrintCatList(List<People> pplList,List<Pet> pets,string gender)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(pplList.Where(g=>g.Gender == gender).FirstOrDefault().Gender);
            Console.WriteLine("------------------");

            foreach (var cat in pets)
            {
                Console.WriteLine(cat.Name);
            }
        }
        
        public static List<People> GetJsonData(string url)
        {
            var client = new RestClient(url);

            var response = client.Execute<List<People>>(new RestRequest());
           
            return response.Data;
        }
    }
}
