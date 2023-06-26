namespace Query.QueryModels.Users;

public abstract class UserQueryModel
{
    public string Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }
}