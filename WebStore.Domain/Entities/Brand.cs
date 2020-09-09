using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Brand of Products
    /// </summary>
    [Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
