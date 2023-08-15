using System;

namespace CompareString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter a string:");
            String s2 = Console.ReadLine();

            Console.WriteLine("Considers Cases:");
            Console.WriteLine(s1==s2);

            Console.WriteLine("Ignores cases:");
            Console.WriteLine(s1.ToLower().Equals(s2.ToLower())); 
        }
    }
}