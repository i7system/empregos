using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace api2
{
    public class taxaJuros
    {
        private readonly HttpClient _client = new HttpClient();
        public async Task<double> retornarTaxaJurosAsync()
        {

            //setando os defaults da requisição http
            _client.BaseAddress = new Uri("http://localhost:28317");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

             HttpResponseMessage response = await _client.GetAsync("api/calculajuros");
             string resultString = await response.Content.ReadAsStringAsync();
             double taxa = JsonConvert.DeserializeObject<double>(resultString);

            return taxa;
        }
    }
}