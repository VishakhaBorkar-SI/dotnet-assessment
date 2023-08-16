namespace ExtractSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "helloworld";
            string res=str.Substring(1, str.Length-2 );
            Console.WriteLine(res);
        }
    }
}