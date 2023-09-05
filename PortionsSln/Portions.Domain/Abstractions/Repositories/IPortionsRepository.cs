using Portions.Domain.Entities;

namespace Portions.Domain.Abstractions.Repositories;

public interface IPortionsRepository
{
    Task<List<Portion>> GetPortions(CancellationToken cancellationToken);
    Task<Portion?> GetPortionById(Guid id, CancellationToken cancellationToken);
    Task<Guid?> AddPortion(Portion portion, CancellationToken cancellationToken);
    Task<Guid?> UpdatePortion(Portion portion, CancellationToken cancellationToken);
    void DeletePortion(Guid id, CancellationToken cancellationToken);
}