namespace DietCraft.Domain.Products;

public class Product : BaseEntity<int>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public required Measurements Measurement { get; set; }
    public required double Amount { get; set; }
}