namespace Database.Entities;

/// <summary>
/// The different types of attributes that a <see cref="Product"/> can have
/// </summary>
public class Attribute
{
    public int Id { get; set; }
    /// <summary>
    /// The name of the product attribute
    /// </summary>
    public string Name { get; set; }
}