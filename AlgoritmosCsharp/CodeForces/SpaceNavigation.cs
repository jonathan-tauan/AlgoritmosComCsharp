using System;

namespace AlgoritmosComCSharp.CodeForces
{
    class SpaceNavigation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string pos = Console.ReadLine();
                string[] sep = pos.Split(" ");
                int x = int.Parse(sep[0]); 
                int y = int.Parse(sep[1]);

                string s = Console.ReadLine();
                
                int R = s.Count(a => a == 'R');
                int U = s.Count(a => a == 'U');
                int D = s.Count(a => a == 'D');
                int L = s.Count(a => a == 'L');

                if (x >= 0)
                {
                    if (R >= x) x = 0;
                }
                else
                {
                    if (L >= Math.Abs(x)) x = 0;
                }

                if (x != 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }


                if (y >= 0)
                {
                    if (U >= y) y = 0;
                }
                else
                {
                    if (D >= Math.Abs(y)) y = 0;
                }

                if (y == 0)
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
