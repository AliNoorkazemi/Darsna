namespace Domain.Shared;

public class Domain<TKey>
{
    public TKey Id { get; set; }

    public void SetId(TKey key)
    {
        Id = key;
    }
}