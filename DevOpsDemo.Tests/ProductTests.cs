using Xunit;

public class ProductTests
{
    [Fact]
    public void Test_ProductList_HasItems()
    {
        var products = new[]
        {
            new { Id = 1, Name = "Laptop", Price = 1200 },
            new { Id = 2, Name = "Mouse", Price = 25 }
        };
        Assert.NotEmpty(products);
    }
}
