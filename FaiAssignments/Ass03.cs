using System;

namespace FaiAssignments
{
    internal static class Calculator
    {
        private static void Main(string[] args)
        {
            int choice;
            bool flag = true;
            do
            {
                Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div 5.Square 6.SquareRoot");
                choice = int.Parse(Console.ReadLine());
                flag = Calc(choice);
            } while (flag);
        }

        private static bool Calc(int choice)
        {
            int num2 = -1;
            int num1 = -1;
            if (choice <= 6 && choice > 0)
            {
                Console.WriteLine("Enter the numbers to be operated");
                num1 = int.Parse(Console.ReadLine());
                if (choice != 5 && choice != 6)
                    num2 = int.Parse(Console.ReadLine());
            }
            switch (choice)
            {
                case 1: Console.WriteLine(num1 + num2); break;
                case 2: Console.WriteLine(num1 - num2); break;
                case 3: Console.WriteLine(num1 * num2); break;
                case 4: Console.WriteLine(num1 / num2); break;
                case 5: Console.WriteLine(num1 * num1); break;
                case 6: Console.WriteLine(Math.Sqrt(num1)); break;
                default: return false;
            }
            return true;
        }
    }
}