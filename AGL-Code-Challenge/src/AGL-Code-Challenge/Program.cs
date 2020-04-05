using AGL_Code_Challenge.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AGL_Code_Challenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public List<People> GetDeserializedReleases(string url)
        {
            var client = new RestClient(url);

            var response = client.Execute<List<People>>(new RestRequest());

            return response.Data;
        }
    }
}
