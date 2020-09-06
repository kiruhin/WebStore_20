using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain
{
    /// <summary>
    /// Filter for Products
    /// </summary>
    public class ProductFilter
    {
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
    }
}
