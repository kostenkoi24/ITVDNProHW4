using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string testHTMLCode = File.ReadAllText(@"TestHTMLCode.txt");

            StreamWriter resultFile = new StreamWriter("Result.txt");



            //WebClient client = new WebClient();
            //string downloadString = client.DownloadString("https://hotline.ua/about/contact/");



            var regex = new Regex(@"href='(?<link>\S+)'>(?<text>\S+)</a>");

            for (Match m = regex.Match(testHTMLCode); m.Success; m = m.NextMatch())
            {
                Console.WriteLine($"{m.Groups["link"]}");
                resultFile.WriteLine(m.Groups["link"]);
            }


            regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");

            MatchCollection collection = regex.Matches(testHTMLCode);

            foreach (Match element in collection)
            {
                Console.WriteLine($"{element.Value}");
                resultFile.WriteLine(element.Value);
            }

            regex = new Regex("\\+?[1-9][0-9]{7,14}");

            collection = regex.Matches(testHTMLCode);

            foreach (Match element in collection)
            {
                Console.WriteLine($"{element.Value}");
                resultFile.WriteLine(element.Value);
            }


            //Console.WriteLine(downloadString);
            resultFile.Close();
            Console.ReadKey();
        }
    }
}
