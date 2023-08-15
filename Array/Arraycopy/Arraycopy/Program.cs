namespace Arraycopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];


            Console.WriteLine("Enter the elements:");
            for(int i=0; i<array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Copy of the array:");
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
                Console.WriteLine(array2[i]);
            }
        }
    }
}