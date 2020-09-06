using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var Brands = _productService.GetBrands();
            List<BrandViewModel> brandsVM = new List<BrandViewModel>();
            foreach (var brand in Brands)
            {
                int amountPiece = _productService.GetCountProductsForBrand(brand.Id);
                brandsVM.Add(new BrandViewModel
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Order = brand.Order,
                    AmountPiece = amountPiece
                });
            }
            return View(brandsVM);
        }
    }
}
