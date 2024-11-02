namespace Database.Entities;

public class ProductItemVariation
{
    public int Id { get; set; }
    /// <summary>
    /// A reference to the <see cref="ProductItem"/> that this variation belongs to
    /// </summary>
    /// <remarks>Foreign key to <see cref="ProductItem"/>.Id</remarks>
    public int ProductItemId { get; set; }
    /// <summary>
    /// The size of the product item
    /// </summary>
    /// <remarks>Foreign key to <see cref="ProductSize"/>.Id</remarks>
    public int SizeId { get; set; }
    /// <summary>
    /// The quantity of this item in stock
    /// </summary>
    public int QuantityInStock { get; set; }
}