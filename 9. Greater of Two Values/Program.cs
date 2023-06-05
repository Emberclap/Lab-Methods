namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main()
        {
            string number = (Console.ReadLine());
            var lsitOfInts = number.Select(digit => (int)char.GetNumericValue(digit));
            int[] digits = lsitOfInts.ToArray();
            int evenSum = GetSumOfEvenDigits(digits);
            int oddSum = GetSumOfOddDigits(digits);

            
            GetMultipleOfEvenAndOdds(evenSum, oddSum);


        }
        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int sum = evenSum * oddSum;
            Console.WriteLine(sum);
            return sum;
            
        }
        static int GetSumOfEvenDigits(int[] digits)
        {
           
            int evenSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    evenSum += digits[i];
                }
            }
            return Math.Abs(evenSum);
        }
        static int GetSumOfOddDigits(int[] digits)
        {
            int oddSum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 1)
                {
                    oddSum += digits[i];
                }
            }
            return Math.Abs(oddSum);
        }

    }
}
