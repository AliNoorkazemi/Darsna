namespace Query.QueryModels.Users.Teachers;

public class TeacherQueryModel : UserQueryModel
{
    public IEnumerable<string> ClassIds { get; set; }
}