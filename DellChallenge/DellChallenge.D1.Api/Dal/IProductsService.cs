using DellChallenge.D1.Api.Dto;
using System.Collections.Generic;

namespace DellChallenge.D1.Api.Dal
{
    public interface IProductsService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto GetId(int id);
        ProductDto Add(NewProductDto newProduct);
        bool Delete(int id);
        ProductDto Put(int id, NewProductDto newProduct);
    }
}
