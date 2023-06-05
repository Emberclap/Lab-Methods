namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basee = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            RiseToPower(basee, power);
            
        }
        static double RiseToPower(double basee, double power)
        {
            double result = Math.Pow(basee, power);
            Console.WriteLine(result);
            return result;
        }
    }
}