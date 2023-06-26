namespace Query.QueryModels.Lessons;

public class LessonQueryModel
{
    public string Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Note { get; set; }

    public string MediaId { get; set; }

    public string ClassId { get; set; }
}