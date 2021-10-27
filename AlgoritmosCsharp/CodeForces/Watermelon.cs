using System;

namespace AlgoritmosCsharp.CodeForces
{
    class Watermelon
    {
        static void Main(string[] args)
        {
            byte w;

            w = byte.Parse(Console.ReadLine());

            if (w%2 == 0 && w > 2)
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
