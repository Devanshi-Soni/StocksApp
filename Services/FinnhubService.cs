using StocksApp.ServiceContracts;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace StocksApp.Services
{
    public class FinnhubService : IFinnhubService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public FinnhubService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IpoCalendarResponse> GetIpoDetails(DateOnly fromDate, DateOnly toDate)
        {
            using (HttpClient httpClient = _httpClientFactory.CreateClient())
            {
                // httpResquest msg class is used to create a new request 
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                {
                    // in RequestUri string value is not allowed directly but we have to make uri class object 
                    RequestUri = new Uri($"https://finnhub.io/api/v1/calendar/ipo?from={fromDate:yyyy-MM-dd}&to={toDate:yyyy-MM-dd}&token={_configuration["FinnhubToken"]}"),
                    Method = HttpMethod.Get
                };

                // for sending request 
                HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
                // to read the response using content stream 
                string response = await httpResponseMessage.Content.ReadAsStringAsync();

                //to convert json object that we receive into C# object by decerializing it 
                IpoCalendarResponse calendarResponse = JsonConvert.DeserializeObject<IpoCalendarResponse>(response);
                //var test = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string, object>>>>(response);
                

                //error handling for service 
                if (calendarResponse == null)
                    throw new InvalidOperationException("No response from finnhub server");

                return calendarResponse; 
            }
            
        }
    }
}