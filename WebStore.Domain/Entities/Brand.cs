using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    [Table("Brands")]
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
        public override string Name { get; set; }
        public override int Id { get; set; }        
        public virtual ICollection<Product> Products { get; set; }
    }
}
