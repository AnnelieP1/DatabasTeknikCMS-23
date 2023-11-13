using FM_EntetyFramework.Context;
using FM_EntetyFramework.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFramework.Services;


internal class CategoryService
{
    private readonly DataContext _context;

    public CategoryService(DataContext context)
    {
        _context = context;
    }

    public async Task CreateCategoryAsync(string categoryName)
    {
        if (!await _context.Categories.AnyAsync(x=> x.CategoryName == categoryName))
        {
            _context.Categories.Add(new Enteties.CategoryEntity { CategoryName = categoryName });
            await _context.SaveChangesAsync();
        }
    }

    public async Task<CategoryEntity> GetCategoryAsync(Expression<Func<CategoryEntity, bool>> predicate)
    {
        var categoryEntity = await _context.Categories.FirstOrDefaultAsync(predicate);
        return categoryEntity ?? null!;
    }
        

}