using Portions.Domain.Entities;
using Portions.Infrastructure.Dtos.Models;

namespace Portions.Infrastructure.Dtos;

public static class DtoConversions
{
    public static List<PortionDto> ConvertToDto(this List<Portion> portions)
    {
        return (from portion in portions
                select new PortionDto
                {
                    Id = portion.Id,
                    CreatedDate = portion.CreatedDate,
                    LastModifiedDate = portion.LastModifiedDate,
                    VerseText = portion.VerseText,
                }).ToList();
    }
    public static PortionDto ConvertToDto(this Portion portion)
    {
        return new PortionDto
        {
            Id = portion.Id,
            CreatedDate = portion.CreatedDate,
            LastModifiedDate = portion.LastModifiedDate,
            VerseText = portion.VerseText,
        };
    }
}
