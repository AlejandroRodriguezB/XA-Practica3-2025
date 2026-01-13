using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace WebApi.Tests
{
    public class RedisTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly IDistributedCache _cache = factory.Services.GetRequiredService<IDistributedCache>();

        [Fact]
        public async Task Cache_ShouldStoreAndRetrieveValue()
        {
            await _cache.SetStringAsync("key", "value");

            var result = await _cache.GetStringAsync("key");

            result.Should().Be("value");
        }
    }
}
