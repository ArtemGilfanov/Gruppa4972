// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray();
foreach (int i in a)
    Console.WriteLine(i);