using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.ViewModels
{
    /// <summary>
    /// View Model for Brands
    /// </summary>
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        /// <summary>
        /// Brand rating
        /// </summary>
        public int Rating { get; set; }
    }
}
