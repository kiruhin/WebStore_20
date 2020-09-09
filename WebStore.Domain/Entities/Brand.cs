using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Brand of Products
    /// </summary>
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
