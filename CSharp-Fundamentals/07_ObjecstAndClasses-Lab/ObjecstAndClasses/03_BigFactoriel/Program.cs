﻿using System.Numerics;

namespace _03_BigFactoriel
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);

        }
    }
}