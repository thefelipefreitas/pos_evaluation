using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart;

/// <summary>
/// Response model for GetCart operation
/// </summary>
public class GetCartResult
{
    /// <summary>
    /// The unique identifier of the cart
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The cart's date
    /// </summary>
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// The cart's user id
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The cart's user
    /// </summary>
    public required User User { get; set; }

    /// <summary>
    /// The cart's products
    /// </summary>
    public required List<Product> Products { get; set; }
}
