﻿using Domain.Shared;

namespace Domain.Users;

public abstract class User : Domain<string>
{
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

    protected void Update(string userName, string email, string password, string name)
    {
        UserName = userName;
        Email = email;
        Password = password;
        Name = name;
    }
}