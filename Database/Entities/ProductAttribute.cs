namespace Database.Entities;

/// <summary>
/// A join table between <see cref="Product"/> and <see cref="Attribute"/>
/// </summary>
public class ProductAttribute
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int AttributeId { get; set; }
    public Attribute Attribute { get; set; }    
}