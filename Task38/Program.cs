double[]   array;
bool    sizeWrong = false;
int rangeFrom = 0, rangeTo = 0, arraySize = 0;

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
