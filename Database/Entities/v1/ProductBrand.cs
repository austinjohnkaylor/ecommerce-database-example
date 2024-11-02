namespace Database.Entities;

/// <summary>
/// A brand for a <see cref="Product"/>
/// </summary>
public class ProductBrand
{
    public int Id { get; set; }
    /// <summary>
    /// The name of the brand
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// A brief description of the brand
    /// </summary>
    public string Description { get; set; } = string.Empty;
}