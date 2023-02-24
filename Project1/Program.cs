﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void Main (int number)
{
    if (number < 0)
    {
        Console.Write($"{number} не натуральное число");
    }
    if (number == 0) return;
    Console.Write($"{number} ");
    Main (number - 1);
}

Main(7);