int     number;
string  value;
bool    canParse, polydromic;

Console.Clear();
Console.WriteLine("Проверка числа, является ли оно полидромным");

while (true)
{    
    Console.Write("Введите пятизначное число: ");

    value = Console.ReadLine()?? "";

    if (value.ToLower() == "quit")
        break;

    canParse = int.TryParse(value, out number);

    if (canParse && (number > 9999 && number < 100000))
    {
        polydromic = (number % 10 == number / 10000) && ((number / 1000) % 10 == (number % 100) / 10);

        Console.WriteLine("Число {0} {1}является полидромным", number, !polydromic ? "не " : "");
        break;
    }
    else
        Console.WriteLine("Введеное число не является числом или оно не пятизначное");
}

