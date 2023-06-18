int     i;
string  value;
Boolean canParse;

while (true)
{
    Console.Write("Введите число: ");

    value = Console.ReadLine() ?? "";

    canParse = int.TryParse(value, out i);

    if (canParse && i > 99)
    {
        while (i > 999)
            i /= 10;

        i = i % 10;

        Console.WriteLine($"{value} -> {i}");
        break;
    }
    else
        Console.WriteLine("Введенное число не является трехзначным");        
}
