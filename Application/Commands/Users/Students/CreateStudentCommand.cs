namespace Application.Commands.Users.Students;

public class CreateStudentCommand : CreateUserCommand
{
    public IEnumerable<string> FavoriteClassIds { get; set; }
}