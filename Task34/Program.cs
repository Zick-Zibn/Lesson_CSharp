int     inputNumber = 0;
int[]   array;
bool    numberWrong = false;

while (true)
{
    try
    {
        numberWrong = false;
        Console.Write("Введите число для определения размера массива: ");
        inputNumber = int.Parse(Console.ReadLine()??"");

        if (inputNumber > 0)
        {
            array = InitArray(inputNumber);

            Console.WriteLine($"[{String.Join(", ", array)}] --> {countEvenNumberInArray(array)}");
            break;
        }
        else
        {
            numberWrong = true;
            throw new Exception("Введенное значение должне быть больше ноля");
        }
    }
    catch (Exception exc)
    {
        if (numberWrong)
            Console.WriteLine(exc.Message);
        else
            Console.WriteLine("Не удалось преобразовать введенное значение в число по причине {0}", exc.Message);
    }
}

int[] InitArray(int arraySize)
{
    int[] array = new int[arraySize];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }

    return array;
}

int countEvenNumberInArray(int[] array)
{
    int counter = 0;

    foreach (int index in array)
    {
        if (index % 2 == 0)
            counter++;
    }

    return counter;
}
