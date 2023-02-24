// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 --> 120
// M = 4; N = 8 --> 30


void Main (int arg1, int arg2, int sum)
{
    if (arg1 > arg2) 
    {
        Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}"); 
        return;
    }
    sum = sum + (arg1++);
    Main (arg1, arg2, sum);
}

Main (4, 8, 0);