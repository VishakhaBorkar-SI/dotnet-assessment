namespace NoOfOcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str=Console.ReadLine();
            Console.WriteLine("Enter the character");
            char ch=Convert.ToChar(Console.ReadLine());
            
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {   
                for (int j = 0; j < str.Length; j++)
                {
                    if (ch == str[i])
                    {
                        count++;
                    }
                }
               
            }
            Console.WriteLine(count);
        }
    }
}