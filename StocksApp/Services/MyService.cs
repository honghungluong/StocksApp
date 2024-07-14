namespace StocksApp.Services
{
    public class MyService
    {
        public MyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IHttpClientFactory _httpClientFactory { get; }

        public async void GetAsync()
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://finnhub.io/api/v1/quote?symbol=AAPL&token=cq9p2t1r01qlu7f3act0cq9p2t1r01qlu7f3actg"),
                    Method = HttpMethod.Get
                };
                HttpResponseMessage ResponseMessage = new HttpResponseMessage();
                ResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            }
        }
    }
}
