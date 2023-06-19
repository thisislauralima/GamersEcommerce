using GamersEcommerce.Domain;
using GamersEcommerce.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OracleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : Controller
    {
        IProductCase _productCase;

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
            //return await _context.Products.ToListAsync();
        }
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Product))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async void RegisterNewProduct([FromBody] Product product)
        //{
        //    _context.Products.Add(product);
        //    await _context.SaveChangesAsync();
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]

        //public async void DeleteProduct(int id)
        //{
        //    var product = await _context.Products.FindAsync(id);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}