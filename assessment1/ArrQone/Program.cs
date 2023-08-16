namespace ArrQone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int val=Convert.ToInt32(Console.ReadLine());
            int[] numList=new int[val];
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine($"Enter the value {i + 1}");
                numList[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = numList.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(numList[i]+"\t");
            }
        }
    }
}