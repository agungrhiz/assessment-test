namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Kata : ");
            string input = Console.ReadLine();
            Console.WriteLine("Output : " + SwapChar(input));
            Console.ReadLine();
        }

        static string SwapChar(string input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length; i += 2)
            {
                if (i + 1 < charArray.Length)
                {
                    char temp = charArray[i];
                    charArray[i] = charArray[i + 1];
                    charArray[i + 1] = temp;
                }
            }
            return new string(charArray);
        }        
    }
}