﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(num % 10);