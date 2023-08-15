namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentinel value:");
            double num = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            int count = 0;
            for (double i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the temperature");
                double temp = Convert.ToDouble(Console.ReadLine());
                if (temp > 20 && temp < 130)
                {
                    sum += temp;
                    count++;
                }
                else
                {
                    Console.WriteLine("Enter a valid temperature");
                }
            }
            Console.Write("No. of temperatures entered:" + count);
            Console.Write("\nAverage of temperatures entered:" + (sum / count));
        }
    }
}