using System;

namespace FaiAssignments
{
    internal static class Ass08
    {
        private enum Day
        {
            S, M, T, W, TH, F, SA
        }

        private static bool IsLeapYear(int year)
        { return year % 4 == 0; }

        private static int CalculateDays(int month, int year)
        {
            if (month == 2)
            {
                if (IsLeapYear(year)) return 29;
                return 28;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                return 31;
            return 30;
        }

        private static int FindStartDay(int month, int year)
        {
            return (int)DateTime.Parse($"1/{month}/{year}").DayOfWeek;
        }

        private static void PrintCalender(int month, int year)
        {
            if (month < 1 && month > 12) throw new Exception("No such month exists");
            foreach (string item in Enum.GetNames(typeof(Day)))
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
            var days = CalculateDays(month, year);
            var space = FindStartDay(month, year);
            int count = 0;
            for (int j = 0; j <= space; j++)
            {
                Console.Write("   ");
                count++;
            }
            for (int i = 1; i <= days; i++)
            {
                Console.Write($" {i} ");
                count++;
                if (count > 7)
                {
                    Console.WriteLine();
                    count = 1;
                }
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            PrintCalender(8, 2018);
        }
    }
}