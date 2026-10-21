
namespace EduHub.Ch02.Domain;

/// <summary>Câu lạc bộ bóng đá.</summary>
public class Club
{
    public const int MaxMembers = 50;
    public const int MaxNameLength = 100;

    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    // Tạo câu lạc bộ và kiểm tra tên hợp lệ.
    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Tên câu lạc bộ không được để trống.");
        }

        if (name.Length > MaxNameLength)
        {
            throw new ArgumentException(
                $"Tên câu lạc bộ không được vượt quá {MaxNameLength} ký tự.");
        }

        return new Club
        {
            Id = Guid.NewGuid(),
            Name = name,
            Description = description
        };
    }

    // Kiểm tra câu lạc bộ còn chỗ cho cầu thủ hay không.
    public bool HasRoom(int currentMemberCount)
    {
        return currentMemberCount < MaxMembers;
    }
}
