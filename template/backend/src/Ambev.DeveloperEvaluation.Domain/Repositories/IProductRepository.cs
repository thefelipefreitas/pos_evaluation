using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(Guid id);

    Task<Product> AddAsync(Product product);

    Task<Product> UpdateAsync(Product product);

    Task<bool> DeleteAsync(Guid id);
}
