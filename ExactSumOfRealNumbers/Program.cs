﻿decimal num = decimal.Parse(Console.ReadLine());
decimal sum = 0;
for (int i = 0; i < num; i++)
{
    sum += decimal.Parse(Console.ReadLine());
}
Console.WriteLine(sum);