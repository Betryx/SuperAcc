using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Domain.Enteties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Furniro.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productContoller;

        public ProductsController(IProductRepository productContoller)
        {
            _productContoller = productContoller;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var products = await _productContoller.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _productContoller.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult>Create(Product product)
        {
            await _productContoller.CreateAsync(product);
            return CreatedAtAction(nameof(GetById),
 new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id,Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            await _productContoller.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productContoller.DeleteByIdAsync(id);
            return NoContent();

        }
    }
}
