using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var product = new List<Product>()
            {
                new Product{ Id = 1 , ProductName = "Computer"},
                new Product{ Id = 2 , ProductName = "Keyboard"},
                new Product{ Id = 3 , ProductName = "Mouse"},

            };
            _logger.LogInformation("GettAllProduct Action has been called"); 
            return Ok(product);
        }

        [HttpPost]
        public IActionResult PostProduct([FromBody]Product product)
        {
            _logger.LogWarning("Product has been created.");
            return StatusCode(201);
        }
    }
}
