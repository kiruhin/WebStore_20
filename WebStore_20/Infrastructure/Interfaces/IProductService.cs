using System.Collections.Generic;
using WebStore.Domain;
using WebStore.Domain.Entities;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
        int GetRatingBrand(int idBrand);

        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}
