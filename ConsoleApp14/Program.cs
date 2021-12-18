using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "И поэтому все так произошло";

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
