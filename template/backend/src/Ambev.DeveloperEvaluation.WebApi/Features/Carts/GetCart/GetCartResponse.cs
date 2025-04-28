using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart;

/// <summary>
/// API response model for GetCart operation
/// </summary>
public class GetCartResponse
{
    /// <summary>
    /// The unique identifier of the cart
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The cart's userid
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The cart's user
    /// </summary>
    public required User User { get; set; }

    /// <summary>
    /// The cart's list of products
    /// </summary>
    public required List<Product> Products { get; set; }
}
