using Domain.Shared;
using MongoDB.Bson;

namespace Domain.Classes;

public class Class : Domain<string>
{
    public string Name { get; set; }

    public string TeacherId { get; set; }

    public Class(string name, string teacherId)
    {
        Name = name;
        TeacherId = teacherId;
    }

    public void Update(string name, string teacherId)
    {
        Name = name;
        TeacherId = teacherId;
    }
}