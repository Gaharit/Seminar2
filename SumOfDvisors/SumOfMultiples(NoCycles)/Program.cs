using System;

namespace sum_of_multiples
{
    class Program
    {

        static int SumOfLower (int number)
        {
            if (number < 1)
                return 0;
            if (number == 1)
                return 1;
            return number + SumOfLower(number - 1);
        }

        static int SumOfMultiples(int max, int divisor)
        {
            return divisor * SumOfLower((max-1)/divisor);
        }

        static void Main(string[] args)
        {
            int sum, max = 1000, divisor1 = 3, divisor2 = 5;
            sum = SumOfMultiples(max, divisor1) + SumOfMultiples(max, divisor2) - SumOfMultiples(max, divisor1 * divisor2);
            Console.WriteLine("Sum of positive numbers less than {0} that can be divided by {1} or {2} is {3}", max, divisor1, divisor2, sum);
            Console.ReadKey();
        }
    }
}