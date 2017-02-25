using System;

namespace percent
{
    class Program
    {
        static int months = 12, percent = 100;
        public static double Calculate(string userInput)
        {
            string[] separator = new string[] {" "};

            string[] info = userInput.Split(separator, System.StringSplitOptions.None);
            double sum = double.Parse(info[0]);
            double interestRate = double.Parse(info[1]) / months / percent;
            int time = int.Parse(info[2]);
            sum *= Math.Pow(1 + interestRate, time);
            return sum;
        }
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            Console.WriteLine(Calculate(userInput));
            Console.ReadKey();
        }
    }
}
