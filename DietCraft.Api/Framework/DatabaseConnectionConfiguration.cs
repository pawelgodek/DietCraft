using DietCraft.Infrastructure.Persistance;

namespace DietCraft.Framework;

public static class DatabaseConnectionConfiguration
{
    public static void UseDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<MealsDBContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DietCraftDatabase"),
                b => b.MigrationsAssembly(typeof(MealsDBContext).Assembly.FullName)), ServiceLifetime.Transient);
    }
}