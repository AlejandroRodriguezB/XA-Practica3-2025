
using StackExchange.Redis;

namespace WebApi.Tests
{
    public class RedisTests
    {
        [Fact]
        public async Task RedisTest()
        {
            var redisConnection =
                Environment.GetEnvironmentVariable("REDIS_CONNECTION");

            Assert.False(string.IsNullOrEmpty(redisConnection),
                "REDIS_CONNECTION is not defined");

            var redis = await ConnectionMultiplexer.ConnectAsync(redisConnection);
            var db = redis.GetDatabase();

            await db.StringSetAsync("health-test", "ok");
            var value = await db.StringGetAsync("health-test");

            Assert.Equal("ok", value.ToString());
        }
    }
}
