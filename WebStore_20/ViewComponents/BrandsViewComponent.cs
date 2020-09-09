using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain;
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
            var Brands= GetBrands();
            //await Task.Run(Brands);
            return View(Brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            IEnumerable<Brand> brands = _productService.GetBrands();

            var brandsListViewModels = new List<BrandViewModel>();

            foreach (var item in brands)
            {
                var _rating = _productService.GetRatingBrand(item.Id);

                var _model = new BrandViewModel();
                _model.Id = item.Id;
                _model.Name = item.Name;
                _model.Order = item.Order;
                _model.Rating = _rating;

                brandsListViewModels.Add(_model);
            }

            return brandsListViewModels;
        }
    }
}
