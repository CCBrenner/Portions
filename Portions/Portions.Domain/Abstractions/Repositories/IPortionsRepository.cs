using Portions.Domain.Entities;

namespace Portions.Domain.Abstractions.Repositories;

public interface IPortionsRepository
{
    Task<List<Portion>> GetPortions();
    Task<Portion?> GetPortionById(Guid id);
    void AddPortion(Guid id);
    void DeletePortion(Guid id);
}