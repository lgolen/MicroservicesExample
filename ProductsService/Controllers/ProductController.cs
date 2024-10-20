using Microsoft.AspNetCore.Mvc;

namespace ProductsService.Controllers
{
    [ApiController]
    [Route("[controller]")]  // Add this line
    public class ProductsController : ControllerBase
    {
        [HttpGet]  // This method will respond to GET requests
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop", Price = 999.99 },
                new { Id = 2, Name = "Phone", Price = 499.99 }
            };
            return Ok(products);
        }
    }
}
