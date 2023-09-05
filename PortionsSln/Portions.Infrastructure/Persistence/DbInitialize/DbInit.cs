using Portions.Domain.Entities;
using Portions.Infrastructure.Persistence.DbInitialize.Contracts;

namespace Portions.Infrastructure.Persistence.DbInititialize;

public class DbInit : IDbInit
{
    public List<Portion> PortionsList { get; set; }
}