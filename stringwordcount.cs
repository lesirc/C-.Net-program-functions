using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sentence;
            Console.Write("Enter String : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words : " + words.Length);
            Console.ReadKey();

        }
    }
}
