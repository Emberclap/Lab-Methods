namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            
           
            if (values == "char")
            {
                GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
            }
            else if (values == "int")
            {
                GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (values == "string")
            {
                GetMax(Console.ReadLine(), Console.ReadLine());
            }
            
        }
        static string GetMax(string input1, string input2)
        {
            string biggest = "";
            
            if(input1.CompareTo(input2) > 0)
            {
                biggest = input1;
            }
            else
            {
                biggest = input2;
            }
            Console.WriteLine(biggest);
            return biggest;
        }
        static char GetMax(char input1, char input2)
        {
            char biggest = 'a';
            if (input1 > input2)
            {
                biggest = input1;
            }
            else 
            {
                biggest = input2;
            }
            Console.WriteLine(biggest);
            return biggest;
        }
        static int GetMax(int input1, int input2)
        {
            int biggest = 0;
            if (input1 > input2)
            {
                biggest = input1;
            }
            else 
            {
                biggest = input2;
            }
            Console.WriteLine(biggest);
            return biggest;
        }

    }
}