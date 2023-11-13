using FM_EntetyFramework.Context;
using FM_EntetyFramework.Enteties;
using FM_EntetyFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFramework.Services
{
    internal class ProductService
    {
        private readonly DataContext _context;
        private readonly CategoryService _categoryService;


        public ProductService(DataContext context, CategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
        }

        public async Task CreateProductAsync(ProductRegistration product)
        {
            var categoryEntety = await _categoryService.GetCategoryAsync(x => x.CategoryName ==  product.CategoryName);
            if (categoryEntety == null)
            {
                await _categoryService.CreateCategoryAsync(product.CategoryName);
                categoryEntety = await _categoryService.GetCategoryAsync(x => x.CategoryName == product.CategoryName);
            }

            var productEntity = new ProductEntety
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = categoryEntety.Id

            };
            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductEntety>> GetAllProductAsync()
        {
            var products = await _context.Products.Include(x => x.Category).ToListAsync();
            return products;
        }
    }
}
