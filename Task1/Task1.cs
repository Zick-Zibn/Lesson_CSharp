﻿int number1;
int number2;

Console.Clear();
Console.WriteLine("Поиск наибольшего числа из двух");

Console.Write("Введите первое число:");
number1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число:");
number2 = int.Parse(Console.ReadLine() ?? "");

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше числа {number1}");   
}
/*
Console.Clear();

Random rnd = new Random();
int i = rnd.Next(100, 1000);

int a1 = i / 100;

int a2 = (i % 100) % 10;

Console.WriteLine($"{i} -> {a1}{a2}");

int a1;
int a2;

Console.Write("Введите первое число:");
a1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число:");
a2 = int.Parse(Console.ReadLine() ?? "");

if (a1 % a2  == 0)
    Console.WriteLine($"Число {a1} кратно {a2}");
else
    Console.WriteLine($"Число {a1}  не кратно {a2} остаток {a1 % a2}");
*/



