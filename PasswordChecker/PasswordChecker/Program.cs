using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int score = 0;
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "`~[]-=;',./_+\"{}|:<>?!@#$%^&*()";

            Console.WriteLine("Enter your password.");
            string userInput = Convert.ToString(Console.ReadLine());
            if (userInput.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(userInput, uppercase) == true)
            {
                score++;
            }
            if (Tools.Contains(userInput, lowercase) == true)
            {
                score++;
            }
            if (Tools.Contains(userInput, digits) == true)
            {
                score++;
            }
            if (Tools.Contains(userInput, specialChars) == true)
            {
                score++;
            }
            if (userInput == "password" || userInput == "1234")
            {
                score = 0;
            }
            Console.WriteLine($"Your password has a score of {score}");
            switch (score)
            {
                case 1:
                    Console.WriteLine("Thats a pretty weak password.");
                    break;
                case 2:
                    Console.WriteLine("Thats an OK password.");
                    break;
                case 3:
                    Console.WriteLine("Thats a good password.");
                    break;
                case 4:
                    Console.WriteLine("Thats a very strong password.");
                    break;
                case 5:
                    Console.WriteLine("Thats a very strong password.");
                    break;
                default:
                    Console.WriteLine("Do you want to get hacked?");
                    break;
            }

        }
    }
}
