using WebStore.Domain.Entities.Base.Interface;

namespace WebStore.ViewModels
{
    /// <summary>
    /// View Model for Products
    /// </summary>
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
