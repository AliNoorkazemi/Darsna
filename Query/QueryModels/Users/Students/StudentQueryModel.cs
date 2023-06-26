namespace Query.QueryModels.Users.Students;

public class StudentQueryModel : UserQueryModel
{
    public IEnumerable<string> FavoriteClassIds { get; set; }
}