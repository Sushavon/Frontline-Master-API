using System.Net.Http;
using System.Threading.Tasks;

namespace FrontlineMaster.Entity.Logging
{
    public class TargetClient
    {
        private readonly HttpClient _httpClient;

        public TargetClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> SampleAsync()
        {
            var response = await _httpClient.GetAsync("api/values/sample");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
