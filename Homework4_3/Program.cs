using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework4_3
{
    class Program
    {

        string searchSuccessors = "(за)(на)(біля, на)(від)(у)(з, до, у)(після, з)(через) (без)(про)";

        static string testText = File.ReadAllText(@"Successors.txt");

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(testText);


            string pattern = "за |на |біля |на |від |у |з |до |після |через |без |про ";

            // Заміна неприпустимих символів пустими символами.
            string result = Regex.Replace(testText.ToLower(), pattern, "ГАВ!");

            Console.WriteLine(new string ('-',40));

            Console.WriteLine(result);
        }
    }
}
