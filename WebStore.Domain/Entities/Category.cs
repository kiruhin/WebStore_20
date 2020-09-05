using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    public class Category : NameEntity, IOrderEntity
    {
        public override string Name { get; set; }
        public override int Id { get; set; }
        public int Order { get; set; }
        public int? ParentId { get; set; }
    }
}
