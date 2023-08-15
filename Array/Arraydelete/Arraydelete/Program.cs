namespace Arraydelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, pos, n;
            int[] arr1 = new int[50];

            Console.Write("Enter the size of array :");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter elements in the array:\n");
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the position where to delete:\n");
            pos = Convert.ToInt32(Console.ReadLine());
            
            i = 0;
            while (i != pos - 1)
                i++;
            
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("The new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
        }

    }
}
