using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Application.UseCases;
using GamersEcommerce.Service;
using Microsoft.AspNetCore.Mvc;

namespace GamersEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        IProductCase _productCase;

        private const string TokenSecret = "ForTheLoveOfGodStoreAndLoadThisSecurely";
        private static readonly TimeSpan TokenLifeTime = TimeSpan.FromHours(1);
        public ProductController(IProductCase productCase)
        {
            _productCase = productCase;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Product>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productCase.GetAllProductsAsync());
        }

    }
}