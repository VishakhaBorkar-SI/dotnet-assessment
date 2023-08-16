namespace RewAlphOrd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string : ");
            string str=Console.ReadLine();

            Console.WriteLine("Enter the substring : ");
            string substr = Console.ReadLine();

            string ansstr = "";
            int i = 0, j = 0;
            while (i<str.Length)
            {
                if (substr[j] == substr.Length-1)
                {
                    Console.WriteLine(ansstr);
                    break;

                }
                if (substr[j]<substr.Length)
                {
                    if (str[i] == substr[j])
                    {
                        ansstr = ansstr + str[i];
                        i++; j++;
                    }
                    else
                    {
                        i++;
                        j = 0;
                    }
                }
               
            }
        }
    }
}