using System;
using System.Linq;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the length of the password
            int passwordLength = 10;

            // Set the characters that can be used in the password
            char[] passwordCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{};':,.<>/?".ToCharArray();

            // Use the Random class to generate a random password
            Random random = new Random();
            char[] password = Enumerable.Repeat(passwordCharacters, passwordLength)
                .Select(s => s[random.Next(s.Length)]).ToArray();

            // Display the generated password to the user
            Console.WriteLine("Your random password is: ");
            Console.WriteLine(password);
        }
    }
}
