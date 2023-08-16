namespace ControlStructOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the purchase price of an item : ");
            int price=Convert.ToInt32(Console.ReadLine());
            if (price>10000)
            {
                Console.WriteLine("Error : you can't purchase it");
            }
            else
            {
                Console.WriteLine("Approved");
            }
        }
    }
}