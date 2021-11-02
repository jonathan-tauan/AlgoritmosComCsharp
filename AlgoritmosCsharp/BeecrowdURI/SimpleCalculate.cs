using System;
using System.Globalization;

namespace AlgoritmosCsharp.BeecrowdURI
{
    class SimpleCalculate //BEECROWD 1010
    {
        static void Main(string[] args)
        {
            string[] product1 = Console.ReadLine().Split();
            int c1 = int.Parse(product1[0]);
            int u1 = int.Parse(product1[1]);
            double p1 = Convert.ToDouble(product1[2]);

            string[] product2 = Console.ReadLine().Split();
            int c2 = int.Parse(product2[0]);
            int u2 = int.Parse(product2[1]);
            double p2 = float.Parse(product2[2]);

            var sum = (p1 * u1) + (p2 * u2);
            double inte = Math.Truncate(sum);
            string[] aux = sum.ToString("N2").Split(".");
            string fl = aux[1];

            Console.WriteLine("VALOR A PAGAR: R$ " + (inte.ToString("#,#", CultureInfo.InvariantCulture))+"."+fl);
        }
    }
}
