using System;

namespace FaiAssignments
{
    internal static class UIConsole
    {
        internal static int GetInteger(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        internal static double GetDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        internal static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        internal static DateTime GetDateTime(string question)
        {
            Console.WriteLine(question);
            return DateTime.Parse(Console.ReadLine());
        }

        internal static long GetLong(string question)
        {
            Console.WriteLine(question);
            return long.Parse(Console.ReadLine());
        }
    }
}