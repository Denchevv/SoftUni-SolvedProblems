﻿int num = int.Parse(Console.ReadLine());    

int sum = 0;

while (sum < num)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);