using System.Net;

namespace WebApi.Tests
{
    public class HealthTests
    {

        [Fact]
        public async Task HealthEndpoint_ShouldReturn200()
        {
            var baseUrl =
                Environment.GetEnvironmentVariable("WEBAPI_BASE_URL");

            Assert.False(string.IsNullOrEmpty(baseUrl),
                "WEBAPI_BASE_URL is not defined");

            var client = new HttpClient { BaseAddress = new Uri(baseUrl) };

            var response = await client.GetAsync("/health");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}