namespace Arrayreverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Array in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + "   ");
            }

            Console.ReadLine();
        }
    }
}