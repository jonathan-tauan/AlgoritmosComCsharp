﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmosCsharp.HackerRank
{
    class ResultCompare
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>{ 0, 0 };

            for (int i = 0; i <= 2; i++)
            {
                if (a[i] > b[i])
                {
                    result[0]++;
                }
                else if(a[i] < b[i])
                {
                    result[1]++;
                }
            }
            return result;
        }
    }

    class CompareTheTriplets
    {
        public static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = ResultCompare.compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
