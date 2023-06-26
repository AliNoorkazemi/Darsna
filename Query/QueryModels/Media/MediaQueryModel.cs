namespace Query.QueryModels.Media;

public class MediaQueryModel
{
    public string Id { get; set; }

    public string Url { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Size { get; set; }

    public long DurationTicks { get; set; }
}