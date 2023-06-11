int number1;
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
