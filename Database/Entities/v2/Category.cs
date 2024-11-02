namespace Database.Entities.v2;

/// <summary>
/// A category of products in the eCommerce store
/// </summary>
public class Category
{
    public int Id { get; set; }
    /// <summary>
    /// The name of the category
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// The description of the category
    /// </summary>
    public string Description { get; set; } = string.Empty;
    /// <summary>
    /// The Id of the parent of this category
    /// </summary>
    public int ParentCategoryId { get; set; }
}