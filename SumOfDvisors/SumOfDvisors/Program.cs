using System;

namespace sum_of_multiples
{
    class Program
    {
        static int max = 1000, divisor1 = 3, divisor2 = 5;
        static void Main(string[] args)
        {
            int sum = 0, suspect = max;
            while (--suspect > 0)
            {
                if (suspect % divisor1 == 0 || suspect % divisor2 == 0)
                    sum += suspect;
            }
            Console.WriteLine("Sum of positive numbers less than {0} that can be divided by {1} or {2} is {3}", max, divisor1, divisor2, sum);
            Console.ReadKey();
        }
    }
}
