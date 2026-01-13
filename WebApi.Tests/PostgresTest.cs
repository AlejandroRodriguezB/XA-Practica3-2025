using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using WebApi.Services;

namespace WebApi.Tests
{
    public class PostgresTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly IServiceProvider _services = factory.Services;

        [Fact]
        public void Database_ShouldBeReachable()
        {
            using var scope = _services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            db.Database.CanConnect().Should().BeTrue();
        }
    }
}
