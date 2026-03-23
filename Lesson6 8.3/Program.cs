using System;

public class Program
{
    public class User
    {
        private string _username;

        public User(string username)
        {
            _username = username;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Username cannot be empty.");
                    return;
                }

                _username = value;
            }
        }
        public static void Main()
        {
            var user = new User("Witcher01");

            Console.WriteLine($"Starting username: {user.Username}");

            user.Username = "";
            Console.WriteLine($"After invalid update: {user.Username}");

            user.Username = "WhiteWolf";
            Console.WriteLine($"After valid update: {user.Username}");
        }

    }

}
