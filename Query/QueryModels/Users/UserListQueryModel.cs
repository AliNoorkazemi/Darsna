namespace Query.QueryModels.Users;

public abstract class UserListQueryModel
{
    public string Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }
}