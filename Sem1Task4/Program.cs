// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine(Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).Max());

// В строку пишется любое колличество чисел