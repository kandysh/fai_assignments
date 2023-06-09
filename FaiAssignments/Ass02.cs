﻿using System;

namespace FAIDotnetAssignment
{
    internal static class Ass02
    {
        private static void Main()
        {
            int[] nums = new int[] { 21, 46, 78, 9, 10, 3 };
            string odd = "ODD: ";
            string even = "EVEN: ";
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    even += $" {num}";
                }
                else
                {
                    odd += $" {num}";
                }
            }
            Console.WriteLine(odd);
            Console.WriteLine(even);
        }
    }
}