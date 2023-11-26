﻿namespace _02_GreaterNumber
{
    public class Program
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine()
                                .Split(',')
                                .Select(int.Parse)
                                .ToArray();
            int[] secondArr = Console.ReadLine()
                                .Split(',')
                                .Select(int.Parse)
                                .ToArray();

            int[] resultArr = new int[firstArr.Length];


            for (int i = 0; i < firstArr.Length; i++)
            {
                int firstArrNum = firstArr[i];
                for (int j = 0; j < secondArr.Length; j++)
                {
                    int secondArrNum = secondArr[j];
                    if (firstArrNum == secondArrNum)
                    {
                        bool isInRange = (j + 1) < secondArr.Length;
                        if (isInRange)
                        {
                            int nextNum = secondArr[j + 1];
                            if (secondArrNum <= nextNum)
                            {
                                resultArr[i] = nextNum;

                            }
                            else
                            {
                                resultArr[i] = -1;
                            }
                        }
                        else
                        {
                            resultArr[i] = -1;
                        }
                        
                    }
                }
            }


            Console.WriteLine(string.Join(",", resultArr));

        }
    }
}