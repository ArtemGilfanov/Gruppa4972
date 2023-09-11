// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

var numberA = decimal.Parse(Console.ReadLine());
var numberB = decimal.Parse(Console.ReadLine());
if (numberA > numberB)
    Console.WriteLine(numberA);
else
    Console.WriteLine(numberB);      