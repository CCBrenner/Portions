using Portions.Domain.Entities;

namespace Portions.Infrastructure.Persistence.DbInititialize;

public class DbInitFactory
{
    public static DbInit DbOne()
    {
        int initialNumberOfPortions = 7;

        DbInit dbInit = new DbInit();

        List<Portion> portions = new List<Portion>();

        for (int i = 0; i < initialNumberOfPortions; i++)
        {
            portions.Add(Portion.Create(Guid.NewGuid()));
        }

        dbInit.PortionsList = portions;

        return dbInit;
    }
}