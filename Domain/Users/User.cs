namespace Domain.Users;

public abstract class User
{
    public string _id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    protected User(string userName, string email, string password, string name)
    {
        UserName = userName;
        Email = email;
        Password = password;
        Name = name;
    }
}