
namespace EduHub.Ch02.Domain;

/// <summary>Cầu thủ của một câu lạc bộ bóng đá.</summary>
public class Member
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public Guid ClubId { get; set; }
}
