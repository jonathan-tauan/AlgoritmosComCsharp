using System;

namespace AlgoritmosCsharp.CodeForces
{
    class Watermelon
    {
        static void Main(string[] args)
        {
            byte m;

            m = byte.Parse(Console.ReadLine());

            if (m%2 == 0 && m > 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
