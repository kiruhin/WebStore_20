using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base.Interface
{
    public interface INamedEntity: IBaseEntity
    {
        public int Id { get; set; }
        public string  Type { get; set; }
    }
}
