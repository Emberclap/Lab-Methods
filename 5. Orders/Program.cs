namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            int quntity = int.Parse(Console.ReadLine());
            TotalPriceCalculator(drink, quntity);
        }
        static void TotalPriceCalculator(string drink, int quantity)
        {
            decimal price = 0;
            switch (drink)
            {
                case "coffee": price = 1.50m;break;
                case "water": price = 1.00m; break;
                case "coke": price = 1.40m; break;
                case "snacks": price = 2.00m; break;
                
            }
            Console.WriteLine(quantity * price);
        }
    }
}