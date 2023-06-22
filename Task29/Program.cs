int[] array;
int firstRange = 0;
int secondRange = 0;

GetNumberRange(ref firstRange, ref secondRange);

array = FillArray(firstRange, secondRange);
ShowArray(array);

static void GetNumberRange(ref int firstRange, ref int secondRange)
{
    while (true)
    {
        try
        {
            Console.Write("Введите начала диапазона: ");
            firstRange = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите конец диапазона: ");
            secondRange = int.Parse(Console.ReadLine()??"");

            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine("Диапазон введен не верно {0}", exc.Message);
        }
    } 
}

static int[] FillArray(int firstRange, int secondRange)
{
    int i = 0;
    int[] array = new int[8];
    Random  rnd = new Random();

    while (i < array.Length)
    {
        array[i] = rnd.Next(firstRange, secondRange);
        i++;
    }
    
    return array;
}

static void ShowArray(int[] array)
{
    int i = 0;

    while (i < array.Length)
    {
        Console.Write("{0}{1}",array[i], i == 7 ? "" : ",");
        i++;
    }

    Console.Write(" -> [");
    i = 0;

    while (i < array.Length)
    {
        Console.Write("{0}{1}",array[i], i == 7 ? "" : ",");
        i++;
    }
    Console.Write("]");
}