using System;

namespace FaiAssignments
{
    internal class Ass09
    {
        public static string ReverseByWords(string sentence)
        {
            if (sentence == null) { throw new Exception("sentence is not valid"); }
            string[] words = sentence.Split(' ');
            string response = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                response += $"{words[i]} ";
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseByWords("my name is vinod and i live in Bangalore"));
        }



    }
}
