﻿namespace _04EqualArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] firstArr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] secondArr = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int sum = 0;
            
            for (int i = 0; i < firstArr.Length; i++)
            {

                if (firstArr[i] == secondArr[i])
                {
                    sum += firstArr[i];
                   
                }
                else
                {
                    int indexOfDiff = i;
                    Console.WriteLine($"Arrays are not identical. Found difference at {indexOfDiff} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}