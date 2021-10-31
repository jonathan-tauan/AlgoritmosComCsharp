using System;

namespace AlgoritmosCsharp.CodeForces
{
    class Team
    {
        static void Main(string[] args)
        {
            int problems, count=0, finalCount = 0;

            problems = int.Parse(Console.ReadLine());

            for (int i = 0; i < problems; i++)
            {
                string[] know = Console.ReadLine().Split();

                for (byte j = 0; j < 3; j++)
                {
                    if (_ = byte.Parse(know[j]) == 1)
                    {
                        count++;                      
                    }
                }

                if (count >= 2)
                {
                    finalCount++;
                }
                count = 0;
            }
            Console.WriteLine(finalCount);
        }
    }
}
