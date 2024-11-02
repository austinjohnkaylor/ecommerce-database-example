namespace Database.Entities;

public class AttributeValue
{
    public int Id { get; set; }
    /// <summary>
    /// The <see cref="Attribute"/> that this value belongs to
    /// </summary>
    /// <remarks>Foreign key to <see cref="Attribute"/>.Id</remarks>
    public int ProductAttributeId { get; set; }
    /// <summary>
    /// The value of the attribute
    /// </summary>
    public required string Value { get; set; }
}