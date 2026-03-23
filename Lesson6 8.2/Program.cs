using System;

public class User
{
    private readonly string _name;
    private readonly string _surname;
    private string _username;
    private string _email;

    public User(string name, string surname, string username, string email)
    {
        _name = name;
        _surname = surname;
        _username = username;
        _email = email;
    }

    public string Name => $"{_name} {_surname}";
    public string Email => _email;

    public void ChangeEmail(string newEmail)
    {
        _email = newEmail;
        Console.WriteLine($"Email updated to: {_email}");
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"{Name} | {_username} | {_email}");
    }

    public static void Main()
    {
        var geralt = new User("Geralt", "of Rivia", "WhiteWolf", "geralt@kaer-morhen.com");

        geralt.DisplaySummary();

        // TODO: Change the email
        // TODO: Print the updated summary
        geralt.DisplaySummary();
        geralt.ChangeEmail("whitewolf@kaer-morhen.com");
        geralt.DisplaySummary();
    }
}