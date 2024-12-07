using DietCraft.Application.Interfaces;
using DietCraft.Domain.Meals;
using DietCraft.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace DietCraft.Infrastructure.Persistance;

public class MealsDBContext: DbContext, IMealsDBContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Meal> Meal { get; set; }
    
    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}