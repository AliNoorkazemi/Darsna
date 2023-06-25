namespace Application.Commands.Users.Teachers;

public class CreateTeacherCommand : CreateUserCommand
{
    public IEnumerable<string> ClassIds { get; set; }
}