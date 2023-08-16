namespace CopyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            int[]arr1 = new int[num];
            int[]arr2 = new int[num];
            Console.WriteLine($"Enter {num} number");
            for (int i = 0; i < num; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("copy in the other array : ");
            for (int i = 0; i < num; i++)
            {
                arr2[i] = arr1[i];
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(arr2[i]);
            }

        }
    }
}