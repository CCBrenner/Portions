using Portions.Domain.Entities;

namespace Portions.Infrastructure.Persistence.DbInitialize.Contracts;

public interface IDbInit
{
    List<Portion> PortionsList { get; set; }
}