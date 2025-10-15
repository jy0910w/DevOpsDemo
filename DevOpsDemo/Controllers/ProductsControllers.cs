using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() =>
        Ok(new[]
        {
            new { Id = 1, Name = "Laptop", Price = 1200 },
            new { Id = 2, Name = "Mouse", Price = 25 }
        });

    [HttpGet("test")]
    public IActionResult Test() =>
        Ok("CI/CD test successful!");
}
