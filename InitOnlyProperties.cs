using System;

class User
{
    public string Username { get; init; } //set at init only
    public string Email { get; set; }

    public User(string  username, string email)
    {
        Username = username;
        Email = email;
    }
}

public static class UserDemo
{
    public static void Run()
    {
        User user = new User("mahin273","md.mahin@gmail.com");
        user.Email = "mahin@gmail.com";
        //user.Username = "Mahin"; //Error -  init-only
    }
}