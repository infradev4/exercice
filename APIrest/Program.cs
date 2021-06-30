using System;

namespace APIrest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://weatherbit-v1-mashape.p.rapidapi.com/forecast/minutely?lat=47.9108&lon=7.2072&units=metric");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "weatherbit-v1-mashape.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
        }
    }
}
