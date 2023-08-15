namespace StringHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            
            int count = 0;
            Console.WriteLine("Enter a particular character:");
            char find = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == find)
                {
                    count++;
                }
            }
            Console.WriteLine($"Occurance of character {find} is {count}");
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}