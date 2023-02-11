using System;
using System.Text.RegularExpressions;

namespace Homework4_6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Напишіть консольну програму, яка дозволяє користувачеві зареєструватися під «Логіном», 
             * що складається тільки з символів латинського алфавіту, 
             * і пароля, що складається з цифр і символів.*/

            Regex regex;
            string pattern;
            string text;

            pattern = @"^[a-z]+$";
            Console.WriteLine("Enter login");
            text = Console.ReadLine(); 
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            Console.WriteLine("Password (only digits and symbol)");
            text = Console.ReadLine();
            pattern = @"^[a-z0-9]+$";
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("{0} == {1} : {2}\n", text, pattern, regex.IsMatch(text));

            Console.ReadKey();
        }
    }
}
