using Npgsql;

namespace WebApi.Tests
{
    public class PostgresTests
    {
        [Fact]
        public async Task DatabaseTest()
        {
            var connectionString =
                Environment.GetEnvironmentVariable("POSTGRES_CONNECTION");

            Assert.False(string.IsNullOrEmpty(connectionString),
                "POSTGRES_CONNECTION is not defined");

            await using var conn = new NpgsqlConnection(connectionString);
            await conn.OpenAsync();

            Assert.Equal(System.Data.ConnectionState.Open, conn.State);
        }
    }
}
