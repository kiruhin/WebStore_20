using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities.Base
{
    public abstract class BaseEntity: IBaseEntity
    {
        public int Id { get; set; }
    }
}
