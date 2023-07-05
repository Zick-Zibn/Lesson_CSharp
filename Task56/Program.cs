int arrayRows = 0, arrayColumns = 0;

GetDataFromUser(ref arrayRows, ref arrayColumns);

int[,] array = InitArray(arrayRows, arrayColumns);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {GetRowSmallSumElements(array)} строке");

void GetDataFromUser(ref int qtyRows, ref int qtyColumns)
{
    bool inputWrong = false;

    while (true)
    {
        try
        {
            inputWrong = false;

            Console.Write("Введите количество строк массива: ");
            qtyRows = int.Parse(Console.ReadLine() ?? "");

            if (qtyRows <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество строк не может быть меньше или равно нулю");
            }
            Console.Write("Введите количество столбцов массива: ");
            qtyColumns = int.Parse(Console.ReadLine() ?? "");

            if (qtyColumns <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество столбцов не может быть меньше или равно нулю");
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

int[,] InitArray(int arrayRows, int arrayColumns)
{
    int[,] array = new int[arrayRows, arrayColumns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = new Random().Next(1, 11);
        }        
    }
    return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Console.Write($"{inArray[i,k]} ");   
        }  
        Console.WriteLine();
    }
}
int GetRowSmallSumElements(int[,] array)
{
    int sumElementRow = 0, rowNum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumTemp = 0;

        for (int k = 0; k < array.GetLength(1); k++)
        {
            sumTemp += array[i, k];   
        }

        if (i == 0)
        {
            sumElementRow = sumTemp;  
            rowNum = i + 1;
        }
        else if (sumTemp < sumElementRow)
        {
            sumElementRow = sumTemp;
            rowNum = i + 1;
        }
    }
    return rowNum;
}
/*
Введите количество строк массива: 6
Введите количество столбцов массива: 3
9 10 6 
9 6 3
9 3 6
6 4 3
2 5 3
6 8 8
*/