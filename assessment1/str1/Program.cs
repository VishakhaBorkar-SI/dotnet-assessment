namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str1=Console.ReadLine();

            char[] chArr = str1.ToCharArray();
            Array.Sort(chArr);
            string res=new string(chArr);
            Console.WriteLine(res);
        }
    }
}