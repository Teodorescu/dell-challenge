using DellChallenge.D1.Api.Dal;
using DellChallenge.D1.Api.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DellChallenge.D1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        [EnableCors("AllowReactCors")]
        public ActionResult<IEnumerable<ProductDto>> Get()
        {
            return Ok(_productsService.GetAll());
        }

        [HttpGet("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Get(int id)
        {
            return Ok(_productsService.GetId(id));
        }

        [HttpPost]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Post([FromBody] NewProductDto newProduct)
        {
            var addedProduct = _productsService.Add(newProduct);
            return Ok(addedProduct);
        }

        [HttpDelete("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult Delete(int id)
        {
            var success = _productsService.Delete(id);
            if (success)
                return Ok();
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        [EnableCors("AllowReactCors")]
        public ActionResult<ProductDto> Put(int id, [FromBody] NewProductDto newProduct)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            var product = _productsService.Put(id, newProduct);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
