using System.Diagnostics.CodeAnalysis;

namespace ArrayHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sum of array
            int sum = 0;

            for(int i=0; i<arr.Length;i++)
            {
               sum = sum+ arr[i];
            }
            Console.WriteLine("Sum of all elements in the array: " + sum);

            Console.ReadLine();

        }
    }
}