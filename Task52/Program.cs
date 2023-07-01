int qtyRows = 0, qtyColumns = 0;

GetDataFromUser(ref qtyRows, ref qtyColumns);

int[,] array = InitArray(qtyRows, qtyColumns);

PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", GetAverageByColumn(array))}.");


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

            Console.Write("Введите количество столбцов массива: ");
            qtyColumns = int.Parse(Console.ReadLine() ?? "");

            if (qtyRows <= 0 || qtyColumns <= 0)
            {
                inputWrong = true;
                throw new Exception($"Количество {(qtyRows <= 0 ? "строк" : "столбцов")} не может быть меньше или равно нулю");
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

int[,] InitArray(int rowsQty, int columnsQty)
{
    int[,] array = new int[rowsQty, columnsQty];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = new Random().Next(1, 10);
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

double[] GetAverageByColumn(int[,] inArray)
{
    double[] arrayAverage = new double[inArray.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            arrayAverage[k] += array[i, k];
        }           
    } 

    for (int i = 0; i < arrayAverage.Length; i++)
    {
        arrayAverage[i] = Math.Round(arrayAverage[i] / inArray.GetLength(0), 2);     
    }
    return arrayAverage;
}
/*
Введите количество строк массива: 4
Введите количество столбцов массива: 4
2 9 9 7 
1 7 3 9
5 5 9 9
4 2 1 8

Среднее арифметическое каждого столбца: 3; 5,75; 5,5; 8,25.
*/