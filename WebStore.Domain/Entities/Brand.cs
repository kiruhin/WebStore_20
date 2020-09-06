using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
        public override string Name { get; set; }
        public override int Id { get; set; }        
    }
}
