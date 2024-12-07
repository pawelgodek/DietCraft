using DietCraft.Domain.Products;

namespace DietCraft.Domain.Meals;

public class Meal : BaseEntity<int>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }

    public required Product[] Products { get; set; }
}