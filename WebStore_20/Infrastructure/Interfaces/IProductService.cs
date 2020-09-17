using System.Collections.Generic;
using WebStore.Domain;
using WebStore.Domain.Entities;

namespace WebStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface for create service products
    /// </summary>
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
        int GetRatingBrand(int idBrand);

        IEnumerable<Product> GetProducts(ProductFilter filter);

        /// <summary>
        /// Get product by Id
        /// </summary>
        /// <param name="id">Id product</param>
        /// <returns>If found return Entity Product,  else return null</returns>
        Product GetProductById(int id);

    }
}
