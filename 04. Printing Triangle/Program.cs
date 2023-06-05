using System.Data.Common;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n, n);

            static void Triangle(int rows, int col)
            {
                for (int i = 1; i <= rows; i++)
                {
                    TrianglePrint(1, i);
                }
                for (int i = col-1; i >= 1; i--)
                {
                    TrianglePrint(1, i);
                }
            }
            static void TrianglePrint(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}