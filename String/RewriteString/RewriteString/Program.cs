namespace RewriteString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char temp;
            Console.WriteLine("Enter a word:");
            string myStr = Console.ReadLine();

            string str = myStr;
            char[] charstr = str.ToCharArray();
            for(int i=1; i < charstr.Length - 1; i++)
            {
                for(int j=0; j<charstr.Length-1; j++)
                {
                    if (charstr[j]> charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr);
            Console.ReadLine();
        }
    }
}