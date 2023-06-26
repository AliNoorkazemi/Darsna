namespace Domain.Media;

public class Media
{
    public string Id { get; set; }

    public string Url { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Size { get; set; }

    public long DurationTicks { get; set; }

    public Media(string url, int size, long durationTicks)
    {
        Url = url;
        Size = size;
        DurationTicks = durationTicks;
        CreatedAt = DateTime.Now;
    }

    public void Update(string url, int size, long durationTicks)
    {
        Url = url;
        Size = size;
        DurationTicks = durationTicks;
    }
}