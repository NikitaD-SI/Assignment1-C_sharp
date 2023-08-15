namespace CheckCredit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the purchase price:");
            int price = Convert.ToInt32(Console.ReadLine());

            if(price> 10000)
            {
                Console.WriteLine("Error Message");
            }
            else
            {
                Console.WriteLine("purchase price:" + price);
            }
            Console.ReadLine();
        }
    }
}