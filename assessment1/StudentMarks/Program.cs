namespace StudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;
            int max = -1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter the marks of student {i+1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int avg = sum / 10;
            Console.WriteLine(avg);
            Console.WriteLine(max);
        }
            
    }
}