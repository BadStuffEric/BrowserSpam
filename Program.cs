using System;

namespace BrowserSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the URL of the website you would like to spam and press Enter. You can right-click on the taskbar icon to exit. ");
            Console.Out.Flush();
            string page = Console.ReadLine();
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}
