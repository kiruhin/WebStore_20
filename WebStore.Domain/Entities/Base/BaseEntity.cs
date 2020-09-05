using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public abstract int Id { get; set; }
    }
}
