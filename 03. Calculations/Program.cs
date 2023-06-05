namespace _03._Calculations
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "add": Add(number1, number2); break;
                case "multiply": Multiply(number1, number2); break;
                case "subtract": Subtract(number1, number2); break;
                case "divide": Divide(number1, number2); break;

            }
        }
        static void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }
        static void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine(result);
        }
        static void Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine(result);
        }
        static void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine(result);
        }

    }
}