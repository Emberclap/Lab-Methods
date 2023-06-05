namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numberOfRepeats = int.Parse(Console.ReadLine());
            Repeat(input, numberOfRepeats);
        }
        static string Repeat(string input, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(input);
            }
            return input;
        }
    }
}