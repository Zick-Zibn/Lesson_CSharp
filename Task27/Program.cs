
GetInputNuber();

static void GetInputNuber()
{
    int number = 0;

    while (true)
    {
        Console.Write("Введите число: ");

        if (int.TryParse(Console.ReadLine() ?? "", out number)) ;
        {
            SumNumber(number);
            break;
        }
    }
}

static int SumNumber(int number)
{
    int sum = 0;

    while (number > 0)
    {
        Console.Write("{0}{1}", number % 10, number > 10 ? "," : "");
        
        sum = sum + (number % 10);
        number = number / 10;
    }
    
    sum = sum + number;
    Console.Write($" -> {sum}");
    return sum;
}
