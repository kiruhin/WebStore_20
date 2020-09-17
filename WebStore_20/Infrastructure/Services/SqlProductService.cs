using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL;
using WebStore.Domain;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Services
{
    /// <summary>
    /// Service for connecting with SQL-Database
    /// </summary>
    public class SqlProductService : IProductService
    {
        private readonly WebStoreContext _context;

        public SqlProductService(WebStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }


        /// <summary>
        /// Method get rating brand
        /// </summary>
        /// <param name="idBrand"></param>
        /// <returns></returns>
        public int GetRatingBrand(int idBrand)
        {
            var query = _context.Products.AsQueryable();
            query = query.Where(c => c.BrandId.Value.Equals(idBrand));
            int _ratingBrand = query.Count();
            return _ratingBrand;
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.AsQueryable();
            if (filter.BrandId.HasValue)
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.CategoryId.HasValue)
                query = query.Where(c => c.CategoryId.Equals(filter.CategoryId.Value));

            return query.ToList();
        }

        
        /// <summary>
        /// Get Product By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public Product GetProductById(int id)
        {
            var query = _context.Products.AsQueryable();
            
            Product first = null;
            foreach (var p in query)
                if (p.Id.Equals(id))
                {
                    first = p;
                    break;
                }
            return first;
        }
    }
}
