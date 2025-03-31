using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public class CreateSaleCommand : IRequest<Sale>
{
    public int CustomerId { get; set; }
    public List<SaleItem> Items { get; set; }

    public CreateSaleCommand(int customerId, List<SaleItem> items)
    {
        CustomerId = customerId;
        Items = items;
    }
}
