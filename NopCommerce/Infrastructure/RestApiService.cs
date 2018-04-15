using RestSharp;
using Json.NET;
using System.IO;
using Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NopCommerce.Infrastructure
{
    public class RestApiService
    {
        private RestClient client;
        private RestRequest request;
        public class ApiItem
        {
            public int Id;
            public int useriID;
            public string title;
            public string body;
        }
 
        string endpointURL = @"https://jsonplaceholder.typicode.com/posts";

        public RestApiService()
        {
            client = new RestClient(endpointURL);
            request = new RestRequest();

            request.Method = Method.GET;
        }


        public List<ApiItem> GetItems()
        {
            IRestResponse response = client.Execute(request);
            var result = response.Content;

            return JsonConvert.DeserializeObject<List<ApiItem>>(result);
        }       
    }
}
