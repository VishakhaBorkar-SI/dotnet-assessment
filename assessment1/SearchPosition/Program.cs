using System.Transactions;

namespace SearchPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the long string : ");
           string longstr= Console.ReadLine();
            Console.WriteLine("Enter the long string : ");
            string shortstr = Console.ReadLine();
            int index=longstr.IndexOf(shortstr);
            Console.WriteLine($"the index is : {index}");
        }
    }
}