using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleRepository
{
    Task<List<Sale>> GetAllAsync();

    Task<Sale?> GetByIdAsync(Guid id);

    Task<Sale> AddAsync(Sale sale);

    Task<Sale> UpdateAsync(Sale sale);

    Task DeleteAsync(Guid id);
}
