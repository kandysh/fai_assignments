using System;

namespace FaiAssignments
{
    internal class Ass07
    {
        private static bool IsPrimeNumber(int number)
        {
            if (number == 2) return true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) { return false; }
            }
            return true;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNumber(3));
        }
    }
}