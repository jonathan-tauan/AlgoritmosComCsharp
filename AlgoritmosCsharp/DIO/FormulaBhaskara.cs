using System;

namespace AlgoritmosCsharp.DIO
{
    class FormulaBhaskara
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] values = Console.ReadLine().Split(" ");
            a = Convert.ToDouble(values[0]);
            b = Convert.ToDouble(values[1]);
            c = Convert.ToDouble(values[2]);

            double ba2 = Math.Pow(b, 2);
            double a4c = 4 * a * c;

            double delta = ba2 - a4c;

            if((delta < 0) || (a==0))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double negativeB = b * -1;
                double rootdelta = Math.Sqrt(delta);
                double denominator = 2 * a;

                double x1 = (negativeB + rootdelta)/denominator;
                double x2 = (negativeB - rootdelta)/denominator;

                Console.WriteLine("R1 = "+ Math.Round(x1, 5));
                Console.WriteLine("R2 = "+ Math.Round(x2, 5));
            }
        }
    }
}
