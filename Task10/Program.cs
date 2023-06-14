int     number;
int     secondNumber;
string  value;
bool    canParse;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    value = Console.ReadLine() ?? "";

    canParse = int.TryParse(value, out number);

    if (canParse && (number > 99 && number < 1000))
    {
        secondNumber = (number / 10) % 10;
        Console.WriteLine($"Вторая цифра числа {number} равна {secondNumber}");
        break;
    }
    else
        Console.WriteLine("Введенное число не трехзначное");
}


