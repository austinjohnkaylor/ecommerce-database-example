namespace Database.Entities;

/// <summary>
/// A category for a product
/// </summary>
public class ProductCategory
{
    public int Id { get; set; }
    /// <summary>
    /// A foreign key to the <see cref="ProductCategory"/> that this <see cref="ProductCategory"/> belongs to
    /// </summary>
    public int ParentProductCategoryId { get; set; }
    /// <summary>
    /// A foreign key to the <see cref="ProductSizeCategory"/> that this size belongs to
    /// </summary>
    public int ProductSizeCategoryId { get; set; }
    /// <summary>
    /// The name of the category
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// A brief description of the product category
    /// </summary>
    public string Description { get; set; } = string.Empty;
    /// <summary>
    /// A link to an image for the category
    /// </summary>
    public string Image { get; set; } = string.Empty;
}