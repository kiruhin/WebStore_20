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
            return View(_productService.GetBrands().Select(c =>
            {
                int amountPiece = _productService.GetCountProductsForBrand(c.Id);
                return new BrandViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Order = c.Order,
                    AmountPiece = amountPiece
                };
            }).OrderBy(c => c.Order).ToList());           
        }
    }
}
