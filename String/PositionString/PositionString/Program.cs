namespace PositionString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string findstr;

            Console.WriteLine("Input a String:");
            str1 = Console.ReadLine();

            Console.WriteLine("Input a substring to be found in the string:");
            findstr = Console.ReadLine();

            int index = str1.IndexOf(findstr);
            if(index<0)
            {
                Console.WriteLine("The substring is not found in the given string:");
            }
            else
            {
                {
                    Console.WriteLine($"Found' {findstr}' in '{str1}' at position {index}");
                }
            }
            Console.ReadLine();
        }
    }
}