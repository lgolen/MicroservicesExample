using Microsoft.AspNetCore.Mvc;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("[controller]")]  // Add this line
    public class OrdersController : ControllerBase
    {
        [HttpGet]  // This method will respond to GET requests
        public IActionResult GetOrders()
        {
            var orders = new[]
            {
                new 
                { 
                    OrderId = 1, 
                    OrderDate = "2024-10-20", 
                    CustomerName = "Alice", 
                    Products = new[] { "Laptop", "Phone" } 
                }
            };
            return Ok(orders);
        }
    }
}
