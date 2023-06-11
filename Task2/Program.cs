int number1;
int number2;
int number3;
int maxNumber = 0;

Console.Write("Введите первое число:");
number1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число:");
number2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число:");
number3 = int.Parse(Console.ReadLine() ?? "");

if (number1 > maxNumber)
    maxNumber = number1;

if (number2 > maxNumber)
    maxNumber = number2;

if (number3 > maxNumber)
    maxNumber = number3;

Console.WriteLine($"Максимальное число {maxNumber}");


