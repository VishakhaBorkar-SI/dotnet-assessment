namespace SumofArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[num];
            int sumAns = 0;

            Console.WriteLine($"Enter {num} numbers : ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sumAns += arr[i];
            }

            Console.WriteLine($"the sum of {num} numbers is {sumAns} ");
            
        }
    }
}