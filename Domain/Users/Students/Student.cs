namespace Domain.Users.Students;

public class Student : User
{
    public IReadOnlyCollection<string> FavoriteClassIds
    {
        get => _favoriteClassIds;
        set => _favoriteClassIds = new SortedSet<string>(value);
    }

    private SortedSet<string> _favoriteClassIds = new();

    public Student(string userName,
        string email,
        string password,
        string name,
        IEnumerable<string> favoriteClassIds)
        : base(userName,
            email,
            password,
            name)
    {
        FavoriteClassIds = favoriteClassIds.ToList();
    }
    
    public void Update(string userName,
        string email,
        string password,
        string name,
        IEnumerable<string> favoriteClassIds)
    {
        base.Update(userName, email, password, name);
        FavoriteClassIds = favoriteClassIds.ToList();
    }
}