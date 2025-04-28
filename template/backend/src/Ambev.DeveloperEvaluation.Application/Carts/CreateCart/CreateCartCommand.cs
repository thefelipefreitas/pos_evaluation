using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Command for creating a new cart.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a cart,
/// including date, user id, user and products.
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request
/// that returns a <see cref="CreateCartResult"/>.
///
/// The data provided in this command is validated using the
/// <see cref="CreateCartCommandValidator"/> which extends
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly
/// populated and follow the required rules.
/// </remarks>
public class CreateCartCommand : IRequest<CreateCartResult>
{
    public string Date { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public required User User { get; set; }

    public required List<Product> Products { get; set; }
}
