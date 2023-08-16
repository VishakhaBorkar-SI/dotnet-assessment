namespace DeleteElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"Enter {num} numbers ");
            for (int j = 0; j < num; j++)
            {
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the position number from where the element get remove : ");
            int pos=Convert.ToInt32(Console.ReadLine());
            
            int i = 0;
            while (i!=pos-1)
            {
                i++;
            }
            //Console.WriteLine(i);
            
            while (i<num-1)
            {
                arr[i] = arr[i + 1];
                ++i;
            }

            for (int j = 0; j < num-1; j++)
            {
                Console.WriteLine(arr[j]);
            }
            
        }
    }
}