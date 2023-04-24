using System;

namespace FaiAssignments
{
    internal class Ass06
    {
        private static bool IsValidDate(int year, int month, int day)
        {
            if (month >= 1 && month <= 12)
            {
                if (month % 2 != 0 && day >= 1 && day <= 31)
                {
                    return true;
                }
                else
                {
                    if (month % 2 == 0 && day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    if (month == 2 && DateTime.IsLeapYear(year) && day > 1 && day <= 29) { return true; }
                    if (day > 1 && day <= 28) { return true; }
                }
            }
            return false;
        }
    }
}