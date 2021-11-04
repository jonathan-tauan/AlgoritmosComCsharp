using System;

namespace AlgoritmosCsharp.CodeForces
{
    class NextRound
    {
        static void Main()
        {
            byte count = 0;

            string[] a = Console.ReadLine().Split();
            byte n = byte.Parse(a[0]);
            byte k = byte.Parse(a[1]);

            string[] b = Console.ReadLine().Split();
            byte kPos = byte.Parse(b[k-1]);

            for (int i = 0; i < n; i++)
            {
                if ((_ = byte.Parse(b[i]) >= kPos) && (_ = byte.Parse(b[i])> 0))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
