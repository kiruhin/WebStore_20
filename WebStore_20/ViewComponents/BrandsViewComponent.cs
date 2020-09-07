using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.ViewComponents
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public BrandsViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Brands = GetBrands();

            return View(Brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            IEnumerable<Brand> brands = _productService.GetBrands();

            var brandsListViewModels = new List<BrandViewModel>();
            foreach (var item in brands)
            {
                brandsListViewModels.Add(new BrandViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Order = item.Order
                    
                });
            }
            //var brandsList = brands.ToList()
            return brandsListViewModels;
        }
    }
}
