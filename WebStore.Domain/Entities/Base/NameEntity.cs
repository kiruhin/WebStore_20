using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities.Base
{
    public abstract class NameEntity : INamedEntity
    {
        public abstract string Name { get; set; }
        public abstract int Id { get; set; }
    }
}
