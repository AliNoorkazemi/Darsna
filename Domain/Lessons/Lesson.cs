using Domain.Shared;

namespace Domain.Lessons;

public class Lesson : Domain<string>
{
    public DateTime CreatedAt { get; set; }

    public string Note { get; set; }

    public string MediaId { get; set; }

    public string ClassId { get; set; }
   
    public Lesson(string note, string mediaId, string classId)
    {
        Note = note;
        MediaId = mediaId;
        ClassId = classId;
        CreatedAt = DateTime.Now;
    }
    
    public void Update(string note, string mediaId, string classId)
    {
        Note = note;
        MediaId = mediaId;
        ClassId = classId;
    }
}