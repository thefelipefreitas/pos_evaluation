using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Command for creating a new product.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a product,
/// including title, description, category, image and rating.
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request
/// that returns a <see cref="CreateProductResult"/>.
///
/// The data provided in this command is validated using the
/// <see cref="CreateProductCommandValidator"/> which extends
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly
/// populated and follow the required rules.
/// </remarks>
public class CreateProductCommand : IRequest<CreateProductResult>
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public Rating? Rating { get; set; }

    // public ValidationResultDetail Validate()
    // {
    //     var validator = new CreateProductCommandValidator();
    //     var result = validator.Validate(this);
    //     return new ValidationResultDetail
    //     {
    //         IsValid = result.IsValid,
    //         Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
    //     };
    // }
}
