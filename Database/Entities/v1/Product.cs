namespace Database.Entities;

/// <summary>
/// A product on the eCommerce site
/// </summary>
public class Product
{
    public int Id { get; set; }
    /// <summary>
    /// The <see cref="ProductCategory"/> that this product belongs to
    /// </summary>
    /// <remarks>Foreign key to the <see cref="ProductCategory"/>.Id</remarks>
    public int ProductCategoryId { get; set; }
    /// <summary>
    /// The <see cref="ProductBrand"/> that this product belongs to
    /// </summary>
    /// <remarks>Foreign key to the <see cref="ProductBrand"/>.Id. A Product Brand should be the same for each <see cref="ProductItem"/> and each <see cref="ProductItemVariation"/></remarks>
    public int BrandId { get; set; }
    /// <summary>
    /// The name of the product
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// A brief description of the product
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// The height of the model in the image of the product
    /// </summary>
    public string ModelHeight { get; set; }
    /// <summary>
    /// The size of the product the model is wearing in the image of the product
    /// </summary>
    public string ModelSize { get; set; }
    /// <summary>
    /// How to care for the product
    /// </summary>
    public string CareInstructions { get; set; }
    /// <summary>
    /// What the product is made of
    /// </summary>
    public string Composition { get; set; }
}