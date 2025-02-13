using System;

namespace solving_algorithms_and_data_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumNumbers = SumOfDigitOfNumbers(1, 100);
            Console.WriteLine(SumNumbers);
        }
        static int SumOfDigitOfNumbers(int left,int right)
        {
            int sum = 0;
            for (int i = left; i <= right; i ++)
            {
                int p = i;
                while (p > 0)
                {
                    if (p % 2 == 0)
                    {
                        sum += p % 10;
                    }
                    p = p / 10;
                }

            }
            return sum;
        }

    }
}
