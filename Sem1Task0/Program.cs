﻿//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();
//Проверяем, чтобы данные были не пустые
if (inputNum != null)
{
    //парсим введенное число
    int num = int.Parse(inputNum);
    //Находим квадрат числа
    int res = num * num;
    //Выводим данные в консоль
    Console.WriteLine(res);
}