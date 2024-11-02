namespace Database.Entities;

/// <summary>
/// Sizes for <see cref="Product"/>s
/// </summary>
public class ProductSize
{
    public int Id { get; set; }
    /// <summary>
    /// A foreign key to the <see cref="ProductSizeCategory"/> that this size belongs to
    /// </summary>
    public int ProductSizeCategoryId { get; set; }
    /// <summary>
    /// The name of the size
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// The sort order of the size in the list
    /// </summary>
    public int SortOrder { get; set; }
}