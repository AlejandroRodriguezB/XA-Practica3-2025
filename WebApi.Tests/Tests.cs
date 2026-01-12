using WebApi.Dto;

namespace WebApi.Tests
{
    public class Tests
    {
        [Fact]
        public void TestCreateProduct()
        {
            var product = new Product
            {
                Name = "Test",
                Price = 10,
                Amount = 100,
                Id = 1
            };

            Assert.Equal("Test", product.Name);
            Assert.Equal(10, product.Price);
            Assert.Equal(100, product.Amount);
            Assert.Equal(1, product.Id);
        }

        [Fact]
        public void TestUpdateProduct()
        {
            var product = new Product
            {
                Name = "Test",
                Price = 10,
                Amount = 100,
                Id = 1
            };
            product.Price = 15;
            product.Amount = 80;
            Assert.Equal(15, product.Price);
            Assert.Equal(80, product.Amount);
        }

        [Fact]
        public void TestProductId()
        {
            var product = new Product
            {
                Name = "Test",
                Price = 10,
                Amount = 100,
                Id = 1
            };
            Assert.Equal(1, product.Id);
            product.Id = 2;
            Assert.Equal(2, product.Id);
        }
    }
}