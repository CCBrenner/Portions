using Portions.Domain.Abstractions;

namespace Portions.Domain.Entities;

public class Portion : IEntity
{
    public Portion() { }
    private Portion(Guid id, DateTime dateCreated, DateTime lastModifiedDate, string verseText)
    {
        Id = id;
        CreatedDate = dateCreated;
        LastModifiedDate = lastModifiedDate;
        VerseText = verseText;
    }
    public Guid Id { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime LastModifiedDate { get; private set; }
    public string VerseText { get; private set; }

    public static Portion Create(Guid id)
    {
        return new Portion(id, DateTime.Now, DateTime.Now, PopWithLorumIpsumText(id));
    }
    public static Portion Create(Guid id, DateTime dateCreated, DateTime lastModifiedDate, string verseText)
    {
        return new Portion(id, dateCreated, lastModifiedDate, verseText);
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
    public static string PopWithLorumIpsumText(Guid id) => $"{id} - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
}