int arrayRows = 0, arrayColumns = 0;

GetDataFromUser(ref arrayRows, ref arrayColumns);

int[,] array = InitArray(arrayRows, arrayColumns);

PrintArray(array);
Console.WriteLine();
SortArrayRows(array);
PrintArray(array);


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

void SortArrayRows(int[,] array)
{
    int tmp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {           
            for (int k = 0; k < (array.GetLength(1) - (j + 1)); k++)
            {
                if (array[i,k] > array[i, k + 1])
                {                    
                    tmp = array[i,k];
                    array[i,k] = array[i, k + 1];
                    array[i, k + 1] = tmp;
                }               
            }
        }
    }
}
/*
Введите количество строк массива: 5
Введите количество столбцов массива: 5
1 8 3 5 10 
5 2 2 7 3
9 8 5 9 1
1 3 1 5 4
6 8 10 3 10

1 3 5 8 10
2 2 3 5 7
1 5 8 9 9
1 1 3 4 5
3 6 8 10 10
*/