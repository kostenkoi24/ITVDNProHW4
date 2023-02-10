using System;
using System.Net;

namespace Homework4_2
{
    class Program
    {
        static void Main(string[] args)
        {


            WebClient client = new WebClient();
            
            string downloadString = client.DownloadString("https://bud-teh.com.ua/ua/?gclid=CjwKCAiA85efBhBbEiwAD7oLQE9cBG13RGkwjVzEz3zWrQVWjA-L9WZDOcSz2nwfNVRhKQ_ZZzqD7BoCwycQAvD_BwE");
            

            Console.WriteLine(downloadString);
        }
    }
}
