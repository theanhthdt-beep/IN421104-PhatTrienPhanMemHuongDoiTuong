
namespace EduHub.Ch02.Domain;

/// <summary>Trận đấu của câu lạc bộ bóng đá.</summary>
public class Event
{
    public Guid Id { get; set; }
    public Guid ClubId { get; set; }
    public required string Title { get; set; }
    public DateTime Date { get; set; }

    public HashSet<Guid> RegisteredMemberIds { get; } = new();
    public HashSet<Guid> CheckedInMemberIds { get; } = new();

    // Đăng ký tham gia trận đấu.
    // Trả về false nếu cầu thủ đã đăng ký trước đó.
    public bool Register(Guid memberId)
    {
        return RegisteredMemberIds.Add(memberId);
    }

    // Chỉ cầu thủ đã đăng ký mới được xác nhận tham gia.
    public void CheckIn(Guid memberId)
    {
        if (!RegisteredMemberIds.Contains(memberId))
        {
            throw new InvalidOperationException(
                "Cầu thủ chưa đăng ký trận đấu.");
        }

        CheckedInMemberIds.Add(memberId);
    }
}
