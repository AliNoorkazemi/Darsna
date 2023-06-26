namespace Domain.Users.Teachers;

public class Teacher : User
{
    public IReadOnlyCollection<string> ClassIds
    {
        get  => _classIds; 
        set => _classIds = new SortedSet<string>(value);
    }

    private SortedSet<string> _classIds = new();

    public Teacher(string userName, 
        string email, 
        string password, 
        string name,
        IEnumerable<string> classIds) 
        : base(userName, 
            email, 
            password, 
            name)
    {
        ClassIds = classIds.ToList();
    }

    public void Update(string userName, 
        string email, 
        string password, 
        string name,
        IEnumerable<string> classIds)
    {
        base.Update(userName, email, password, name);
        ClassIds = classIds.ToList();
    }
}