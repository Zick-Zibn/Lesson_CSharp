double[]   array;
bool    sizeWrong = false;
int rangeFrom = 0, rangeTo = 0, arraySize = 0;
double minElement = 0, maxElement = 0;

GetDataFromUser(ref rangeFrom, ref rangeTo, ref arraySize);

array = InitArray(arraySize, rangeFrom, rangeTo);

GetMinMaxElement(ref minElement, ref maxElement, array);

Console.WriteLine($"[{String.Join("; ", array)}] => {maxElement} - {minElement} = {(maxElement - minElement):f2}");

void GetDataFromUser(ref int rangeFrom, ref int rangeTo, ref int arraySize)
{
    while (true)
    {
        try
        {
            sizeWrong = false;

            Console.Write("Введите начала диапазона: ");
            rangeFrom = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите конец диапазона: ");
            rangeTo = int.Parse(Console.ReadLine()??"");

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

double[] InitArray(int arraySize, int rangeFrom, int rangeTo)
{
    double[] array = new double[arraySize];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(rangeFrom, rangeTo) + Math.Round(new Random().NextDouble(), 2);
    }

    return array;
}

void GetMinMaxElement(ref double min, ref double max, double[] array)
{
    min = array[0];
    max = array[0];
    
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

        if (array[i]  > max)
            max = array[i];
    }
}
/* Результат выполнения 
Введите начала диапазона: 1
Введите конец диапазона: 100
Введите размер массива: 6
[39,25; 13,1; 53,53; 67,29; 6,91; 45,99] => 67,29 - 6,91 = 60,38
*/