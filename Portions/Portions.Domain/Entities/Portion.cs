using Portions.Domain.Abstractions;

namespace Portions.Domain.Entities;

public class Portion : IEntity
{
    public Portion() { }
    public Portion(Guid id)
    {
        Id = id;
        CreatedDate = DateTime.Now;
        LastModifiedDate = DateTime.Now;
        VerseText = PopWithLorumIpsumText(id);
    }
    public Guid Id { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime LastModifiedDate { get; private set; }
    public string VerseText { get; private set; }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    // to throw out later
    private string PopWithLorumIpsumText(Guid id) => $"{id} - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
}