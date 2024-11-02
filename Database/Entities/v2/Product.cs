namespace Database.Entities.v2;

/// <summary>
/// A product in the eCommerce store
/// </summary>
public class Product
{
    public long Id { get; set; }
    /// <summary>
    /// Foreign key to the <see cref="Category"/> entity
    /// </summary>
    public int CategoryId { get; set; }
    /// <summary>
    /// A Product's <see cref="Category"/>
    /// </summary>
    public Category? Category { get; set; }
    /// <summary>
    /// The name of the product
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// The description of the product
    /// </summary>
    public string Description { get; set; } = string.Empty;
}