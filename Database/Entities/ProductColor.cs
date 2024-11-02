namespace Database.Entities;

/// <summary>
/// Colors for <see cref="Product"/>s
/// </summary>
public class ProductColor
{
    public int Id { get; set; }
    /// <summary>
    /// The hex value of the color
    /// </summary>
    /// <example>#000000 = black</example>
    public string Hex { get; set; }
    /// <summary>
    /// A friendly name for the color
    /// </summary>
    /// <example>black</example>
    public string Name { get; set; }
}