namespace StudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;
            int max = -1;

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine($"Enter marks of students: {i+1}");
                arr[i]=Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Highest Marks obtained: {max}");
            int avg;
            avg = sum / 10;
            Console.WriteLine($"Average marks of all the students: {avg}" );


            Console.ReadLine();

        }
    }
}