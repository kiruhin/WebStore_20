using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    public interface INameEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
