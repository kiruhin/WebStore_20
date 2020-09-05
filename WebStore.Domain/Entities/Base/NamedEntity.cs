using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.Domain.Entities.Base
{
   public class NamedEntity :INamedEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    
}