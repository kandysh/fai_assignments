using System;
using System.Collections.Generic;

namespace FaiAssignments
{
    internal class Ass10
    {
        static Dictionary<int, string> map = new Dictionary<int, string>
            {
            {0,"" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "elven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                {15,"fifteen" },
                {16,"sixteen" },
                {17,"seventeen" },
                {18,"eighteen" },
                {19,"nineteen" },
                {20,"twenty" },
                {30,"thirty" },
                {40,"forty" },
                {50,"fifty" },
                {60,"sixty" },
                {70,"seventy" },
                {80,"eighty" },
                {90,"ninety" }
            };
        static string[] places = new string[] { "hundred,thousand,lac,crore" };
        public static string InWords(int num)
        {
            List<string> nums = new List<string>();
            if (num.ToString().Length > 3)
            {
                nums.Add
            }
        }
        public static string InWordsTwoNumbers(int num)
        {
            string response = "";
            if (map.ContainsKey(num)) { response += map[num]; }
            else
            {
                response += $"{map[(num / 10) * 10]} {map[num % 10]}";
            }

            return response;

        }
        static void Main(string[] args)
        {

            Console.WriteLine(InWords(12161));
        }
    }
}
