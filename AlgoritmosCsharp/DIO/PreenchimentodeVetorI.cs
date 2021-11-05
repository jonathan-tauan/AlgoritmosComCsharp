using System;

namespace AlgoritmosComCSharp.DIO
{
    class PreenchimentodeVetorI
    {
        static void Main(string[] args)
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            n[0] = valorLido;
            
            for (int j = 1; j <=9;j++)
            {
                n[j] = n[j-1] * 2;
            }

            int i = 0;
            
            foreach (int cont in n)
            {
                Console.WriteLine("N["+i+"] = " + cont);
                i++;
            }

        }
    }
}
