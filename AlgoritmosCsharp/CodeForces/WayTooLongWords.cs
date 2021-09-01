using System;

namespace AlgoritmosComCSharp.CodeForces
{
    class WayTooLongWords
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            string input;

            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                int length = input.Length;

                if (length > 10)
                {
                    var first = input.Substring(0,1);
                    var length_2 = Convert.ToString((input.Length)-2);
                    var last = input.Substring(input.Length-1,1);
                    Console.WriteLine(first+length_2+last);

                }
                else
                {
                    Console.WriteLine(input);

                }
            }
        }
    }
}
