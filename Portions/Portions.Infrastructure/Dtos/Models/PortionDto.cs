namespace Portions.Infrastructure.Dtos.Models;

public class PortionDto
{
    public Guid Id { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime LastModifiedDate { get; set; }
    public string VerseText { get; set; }
}
