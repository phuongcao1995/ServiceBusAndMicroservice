using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShareService.ApiClient
{
    public class PeopleApiClient : IPeopleApiClient
    {
        protected readonly HttpClient httpClient;
        public PeopleApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Person>> GetAllPeople()
        {
            httpClient.BaseAddress = new Uri("https://localhost:44338/");
            var url = $"api/people/all";
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Person>>(responseString);
        }
    }
}
