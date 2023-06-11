int number;

Console.WriteLine("Определение четного числа");
Console.Write("Введите число:");

number = int.Parse(Console.ReadLine() ?? "");

if (number % 2 == 0)
    Console.WriteLine("Введенное число является четным");
else
    Console.WriteLine("Введенное число является не четным");
