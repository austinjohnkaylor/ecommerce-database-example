namespace Database.Entities;

/// <summary>
/// An image for a product
/// </summary>
public class ProductImage
{
    public int Id { get; set; }
    /// <summary>
    /// The <see cref="Product"/> that this image belongs to
    /// </summary>
    /// <remarks>Foreign key to <see cref="Product"/>.Id</remarks>
    public int ProductId { get; set; }
    /// <summary>
    /// A link to the image
    /// </summary>
    public string Image { get; set; }
}