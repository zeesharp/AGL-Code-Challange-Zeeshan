using AGL_Code_Challenge.BusinessModels;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static AGL_Code_Challenge.BusinessModels.Enum;

namespace AGL_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = GetJsonData("http://agl-developer-test.azurewebsites.net/people.json");

                var maleCatList = BusinessLogic.GetCatsNameByGender(data, GenderEnum.Male.ToString(), AnimalEnum.Cat.ToString());
                var femaleCatList = BusinessLogic.GetCatsNameByGender(data, GenderEnum.Female.ToString(), AnimalEnum.Cat.ToString());

                PrintCatList(data, maleCatList, GenderEnum.Male.ToString());
                PrintCatList(data, femaleCatList, GenderEnum.Female.ToString());
            }
            catch (Exception ex)
            {
                if (ex is WebException)
                {
                    var e = (WebException)ex;
                    Console.WriteLine(ex.Message);                    
                }
                else
                {
                    Console.Write(ex.Message);
                }
            }
            Console.ReadLine();

        }
        private static void PrintCatList(List<People> pplList, List<Pet> pets, string gender)
        {
            if (pplList.Any())
            {
                Console.WriteLine("------------------");
                Console.WriteLine(pplList.Where(g => g.Gender == gender).FirstOrDefault().Gender);
                Console.WriteLine("------------------");

                foreach (var cat in pets)
                {
                    Console.WriteLine(cat.Name);
                }
            }
            else
            {
                Console.WriteLine("List count is  0");
            }
        }

        public static List<People> GetJsonData(string url)
        {
            List<People> list = new List<People>();
            var client = new RestClient(url);

            var response = client.Execute<List<People>>(new RestRequest());
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                list = response.Data;
            }
            else
            {
                throw response.ErrorException;
            }
            return list;
        }
    }
}
