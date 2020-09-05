using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.ViewModels
{
    public class CategoryViewModel : INameEntity, IOrderEntity
    {
        public string Name { get;set; }
        public int Id { get; set; }
        public int Order { get; set; }
        public List<CategoryViewModel> ChildCategories { get; set; } = new List<CategoryViewModel>();
        public CategoryViewModel ParentCategory { get; set; }
    }
}
