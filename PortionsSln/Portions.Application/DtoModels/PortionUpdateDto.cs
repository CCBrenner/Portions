namespace Portions.Application.DtoModels;

public class PortionUpdateDto
{
    public Guid Id { get; init; }
    public DateTime CreatedDate { get; init; }
    public DateTime LastModifiedDate { get; set; }
    public string VerseText { get; set; }
}
