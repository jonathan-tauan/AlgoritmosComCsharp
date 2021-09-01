using System;

namespace AlgoritmosComCSharp.CodeForces
{
    class StonesOnTheTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            int count = 0;

            for(int i = 0;i < s.Length-1; i++)
            {
                if(s[i] == s[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
