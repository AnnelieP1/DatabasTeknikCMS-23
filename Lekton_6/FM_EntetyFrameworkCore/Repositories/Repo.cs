using FM_EntetyFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFrameworkCore.Repositories;

internal abstract class Repo<TEntity> where TEntity : class
{
    
    private readonly DataContext _context;

    protected Repo(DataContext context)
    {
        _context = context;
    }

    // CREATE
    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        //lägg in try catch
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    // READ
    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        // lägg till try catch
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        return entity ?? null!;

    }

    // READ
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        // lägg till try catch
        var entities = await _context.Set<TEntity>().ToListAsync();
        return entities;
    }

    // UPDATE
    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        //lägg in try catch
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity ?? null!;
    }

    // DELETE
    public virtual async Task<bool> DeleteAsync(TEntity entity)
    {
        //lägg in try catch
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
    //Exists - ingår inte i Crud men är bra att ha. 
    public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression)
    {
        // lägg till try catch
        var exists = await _context.Set<TEntity>().AnyAsync(expression);
        return exists;

    }

}
