﻿// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом 
// второго.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2 * number2 == number1)
{
     Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
} 
else
{
     Console.WriteLine($"Первое число {number1} не является квадратом второго числа {number2}");
}