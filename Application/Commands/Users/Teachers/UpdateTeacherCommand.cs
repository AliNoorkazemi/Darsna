namespace Application.Commands.Users.Teachers;

public class UpdateTeacherCommand : UpdateUserCommand
{
    public IEnumerable<string> ClassIds { get; set; }
}