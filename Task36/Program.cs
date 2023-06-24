int[]   array;
bool    sizeWrong = false;
int rangeFrom = 0, rangeTo = 0, arraySize = 0;

GetDataFromUser(ref rangeFrom, ref rangeTo, ref arraySize);
array = InitArray(arraySize, rangeFrom, rangeTo);

Console.WriteLine($"[{String.Join(",", array)}] -> {sumNotEvenElements(array)}");

void GetDataFromUser(ref int firstRange, ref int secondRange, ref int arraySize)
{
    while (true)
    {
        try
        {
            sizeWrong = false;

            Console.Write("Введите начала диапазона: ");
            firstRange = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите конец диапазона: ");
            secondRange = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите размер массива: ");
            arraySize = int.Parse(Console.ReadLine()??"");

            if (arraySize <= 0)
            {
                sizeWrong = true;
                throw new Exception("Размер массива не может быть меньше или равняться нулю");
            }
            break;
        }
        catch (Exception exc)
        {
            if (sizeWrong)
                Console.WriteLine(exc.Message);
            else
                Console.WriteLine("Невозможно пребразовать введенное значение в число {0}", exc.Message);
        }
    } 
}

int[] InitArray(int arraySize, int rangeFrom, int rangeTo)
{
    int[] array = new int[arraySize];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(rangeFrom, rangeTo);
    }

    return array;
}

int sumNotEvenElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
            sum += array[i];
    }
    return sum;
}
