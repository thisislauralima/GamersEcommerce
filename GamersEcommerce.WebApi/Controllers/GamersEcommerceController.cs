using GamersEcommerce.Domain.Entities;
using GamersEcommerce.Domain.Interfaces.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace GamersEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : Controller
    {
        IProductCase _productCase;

        private const string TokenSecret = "ForTheLoveOfGodStoreAndLoadThisSecurely";
        private static readonly TimeSpan TokenLifeTime = TimeSpan.FromHours(1);
        public EcommerceController(IProductCase productCase)
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

        [HttpPost("token")]
        public IActionResult GenerateToken([FromBody]TokenGenerationRequest request)
        {

        }
    }
}