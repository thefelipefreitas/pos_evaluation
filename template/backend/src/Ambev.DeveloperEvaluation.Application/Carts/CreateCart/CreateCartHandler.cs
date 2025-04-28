using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart;

/// <summary>
/// Handler for processing CreateCartCommand requests
/// </summary>
public class CreateCartHandler : IRequestHandler<CreateCartCommand, CreateCartResult>
{
    private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateCartHandler
    /// </summary>
    /// <param name="cartRepository">The cart repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreateCartCommand</param>
    public CreateCartHandler(ICartRepository cartRepository, IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateCartCommand request
    /// </summary>
    /// <param name="command">The CreateCart command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created cart details</returns>
    public async Task<CreateCartResult> Handle(
        CreateCartCommand command,
        CancellationToken cancellationToken
    )
    {
        var cart = _mapper.Map<Cart>(command);
        var createdCart = await _cartRepository.CreateAsync(cart);
        var result = _mapper.Map<CreateCartResult>(createdCart);
        return result;
    }
}
