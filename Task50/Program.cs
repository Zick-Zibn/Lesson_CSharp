int rowNum = 0; int columnNum = 0;

GetDataFromUser(ref rowNum, ref columnNum);

int[,] array = InitArray();
PrintArray(array);
Console.WriteLine();
ShowFindIndex(array, rowNum, columnNum);

void GetDataFromUser(ref int rowNum, ref int columnNum)
{
    while (true)
    {
        try
        {
            Console.Write("Введите  номер строки массива: ");
            rowNum = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите номер столбца массива: ");
            columnNum = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine("Невозможно пребразовать введенное значение в число по причине {0}", exc.Message);
        }
    }
}

int[,] InitArray()
{
    int[,] array = new int[5, 5];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = new Random().Next(-100, 101);
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

void ShowFindIndex(int[,] inArray, int rowIndex, int columnIndex)
{
    try
    {
        Console.WriteLine($"{rowIndex}, {columnIndex} -> {inArray[rowIndex - 1, columnIndex - 1]}");
    }
    catch(Exception exc)
    {
        Console.WriteLine($"{rowIndex}, {columnIndex} -> такого элемента нет в массиве");
    }
}
/*
Введите  номер строки массива: 3
Введите номер столбца массива: 4
-84 19 57 15 -97 
-14 -49 -25 96 -55
-18 32 6 86 -56
56 37 40 -16 49
92 -8 -18 13 -53

3, 4 -> 86

Введите  номер строки массива: 4
Введите номер столбца массива: 6
-68 86 -7 -100 67 
49 94 -4 82 -87
-68 40 91 -69 6
-52 -40 44 -3 34
-28 -2 -66 -21 5

4, 6 -> такого элемента нет в массиве
*/