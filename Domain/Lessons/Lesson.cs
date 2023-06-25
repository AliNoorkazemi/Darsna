namespace Domain.Lessons;

public class Lesson
{
    public Lesson(string note, string mediaId, string classId)
    {
        Note = note;
        MediaId = mediaId;
        ClassId = classId;
    }

    public string Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Note { get; set; }

    public string MediaId { get; set; }

    public string ClassId { get; set; }
}