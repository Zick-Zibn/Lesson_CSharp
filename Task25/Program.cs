int numberA = 0, numberB = 0;

GetInputNuber(ref numberA, ref numberB);

Console.WriteLine($"{numberA},{numberB} -> {degreeNumber(numberA, numberB)}");

static void GetInputNuber(ref int numberA, ref int numberB)
{
    while (true)
    {
        try
        {
            Console.Write("Введите число А: ");
            numberA = int.Parse(Console.ReadLine() ?? "");
           
            Console.Write("Введите число B: ");
            numberB = int.Parse(Console.ReadLine() ?? "");

            break;
        }
        catch(Exception exc)
        {
            Console.WriteLine("Ошибка ввода чисел {0}", exc.Message);
        }
    }
}

static int degreeNumber(int numberA, int numberB)
{
    int result = numberA;

    for (int i = 1; i < numberB; i++)
    {
        result = result * numberA; 
    }

    return result;
}
