using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

/// <summary>
/// Represents a request to create a new cart in the system.
/// </summary>
public class CreateCartRequest
{
    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user id.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    public required User User { get; set; }

    /// <summary>
    /// Gets or sets the products.
    /// </summary>
    public required List<Product> Products { get; set; }
}
