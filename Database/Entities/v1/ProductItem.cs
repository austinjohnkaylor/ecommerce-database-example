namespace Database.Entities;

public class ProductItem
{
    public int Id { get; set; }
    /// <summary>
    /// The <see cref="Product"/> that this item represents
    /// </summary>
    /// <remarks>Foreign key to <see cref="Product"/>.Id</remarks>
    public int ProductId { get; set; }
    /// <summary>
    /// The color of the product item
    /// </summary>
    /// <remarks>Foreign key to <see cref="ProductColor"/>.Id</remarks>
    public int ColorId { get; set; }
    /// <summary>
    /// The manufacturer set retail price of the product
    /// </summary>
    public decimal MSRP { get; set; }
    /// <summary>
    /// The eCommerce site's price of the product item
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// The eCommerce site's sales price of the product item
    /// </summary>
    public decimal SalesPrice { get; set; }
    /// <summary>
    /// The SKU of the product item
    /// </summary>
    /// <remarks>The SKU is the product code of the <see cref="Product"/>. The SKU is a combination of the product, the size, and it's color. The product code is the same for each size but different for each color.</remarks>
    public long Sku { get; set; }
}