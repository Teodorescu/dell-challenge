using System.Collections.Generic;
using System.Linq;
using DellChallenge.D1.Api.Dto;

namespace DellChallenge.D1.Api.Dal
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext _context;

        public ProductsService(ProductsContext context)
        {
            _context = context;
        }

        public ProductDto GetId(int id)
        {
            return _context.Products.Where(p => p.Id == id).Select(p => MapToDto(p)).FirstOrDefault();
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _context.Products.Select(MapToDto);
        }

        public ProductDto Add(NewProductDto newProduct)
        {
            var product = MapToData(newProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            var addedDto = MapToDto(product);
            return addedDto;
        }

        public bool Delete(int id)
        {
            var product = _context.Products.Find(id);
            var exists = product != null;
            if (exists)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return exists;
        }

        public ProductDto Put(int id, NewProductDto newProduct)
        {
            ProductDto putDto = null;
            var product = _context.Products.Find(id);
            if (product != null)
            {
                product.Name = newProduct.Name;
                product.Category = newProduct.Category;

                _context.SaveChanges();
                putDto = MapToDto(product);
            }
            
            return putDto;
        }

        //

        private Product MapToData(NewProductDto newProduct)
        {
            return new Product
            {
                Category = newProduct.Category,
                Name = newProduct.Name
            };
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category
            };
        }
    }
}
