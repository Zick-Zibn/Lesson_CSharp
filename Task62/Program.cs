int arraySize = 0;

GetDataFromUser(ref arraySize);

int[,] array = new int[arraySize, arraySize];

FillArrayClockwise(array);
PrintArray(array);

void GetDataFromUser(ref int arraySize)
{
    bool inputWrong = false;

    while (true)
    {
        try
        {
            inputWrong = false;

            Console.Write("Введите число N для определения количества строк и столбцов квадратного массива: ");
            arraySize = int.Parse(Console.ReadLine() ?? "");

            if (arraySize <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество не может быть меньше или равно нулю");
            }
            break;
        }
        catch (Exception exc)
        {
            if (inputWrong)
            {
                Console.WriteLine(exc.Message);
            }
            else
                Console.WriteLine("Невозможно пребразовать введенное значение в число {0}", exc.Message);
        }
    }
}

void FillArrayClockwise(int[,] array)
{
    int row = 0, coll = 0, cnt = 0;;

    for (int i = 0; i < array.Length; i++)
    {
        cnt++;
        array[row, coll] = cnt;

        if (row <= coll + 1 && row + coll < array.GetLength(1) - 1)
            coll++;
        else if (row < coll && row + coll >= array.GetLength(0) - 1)
            row++;
        else if (row >= coll && row + coll > array.GetLength(1) - 1)
            coll--;
        else
            row--;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Console.Write($"{inArray[i,k]}\t");   
        }  
        Console.WriteLine();
    }
}
/*
Введите число N для определения количества строк и столбцов квадратного массива: 4
1       2       3       4
12      13      14      5
11      16      15      6
10      9       8       7
*/
