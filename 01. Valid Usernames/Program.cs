using System;

namespace validusername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length > 3 && username.Length < 16)
                {
                    bool IsValid = true;

                    foreach (char currChar in username)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            IsValid = false;
                        }
                    }
                    if (IsValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }

        }
    }
}
