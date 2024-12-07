using DietCraft.Domain.Meals;
using DietCraft.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace DietCraft.Application.Interfaces;

public interface IMealsDBContext
{
    DbSet<Product> Product { get; set; }
    DbSet<Meal> Meal { get; set; }

    Task<int> SaveChangesAsync();
}