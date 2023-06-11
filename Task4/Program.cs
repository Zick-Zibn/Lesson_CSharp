int number;
int i = 1;

Console.WriteLine("Вывод четных чисел");
Console.Write("Введите произвольное число:");

number = int.Parse(Console.ReadLine() ?? "");

while (i <= number)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
    i++;
}
