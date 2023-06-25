namespace Application.Commands.Users.Students;

public class UpdateStudentCommand : UpdateUserCommand
{
    public IEnumerable<string> FavoriteClassIds { get; set; }
}