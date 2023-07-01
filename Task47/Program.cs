int qtyRows = 0, qtyColumns = 0; 
int startRandomNum = 0, endRandomNum = 0;

GetDataFromUser(ref qtyRows, ref qtyColumns, ref startRandomNum, ref endRandomNum);
double[,] array = InitArray(qtyRows, qtyColumns, startRandomNum, endRandomNum);
PrinArray(array);

void GetDataFromUser(ref int qtyRows, ref int qtyColumns, ref int startRandomNum, ref int endRandomNum)
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

            Console.Write("Введите начало диапазона для генерации вещественных чисел: ");
            startRandomNum = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите конец диапазона  для генерации вещественных чисел: ");
            endRandomNum = int.Parse(Console.ReadLine() ?? "");

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

double[,] InitArray(int rowsQty, int columnsQty, int startRandomNum, int endRandomNum)
{
    double[,] array = new double[rowsQty, columnsQty];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = new Random().Next(startRandomNum, endRandomNum + 1) + new Random().NextDouble();
        }        
    }
    return array;
}

void PrinArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
        {
            Console.Write($"{inArray[i,k]:f2}{(k < inArray.GetLength(1) - 1 ? "; ": " ")}");             
        }
        Console.WriteLine();
    } 
}
/*
Введите количество строк массива: 5
Введите количество столбцов массива: 5
Введите начало диапазона для генерации вещественных чисел: -200
Введите конец диапазона  для генерации вещественных чисел: 200
98,64; 2,20; -158,77; 41,39; 105,20     
189,41; 136,38; -86,14; 135,02; 150,24  
-62,90; -68,60; -112,87; 23,68; -130,88 
10,89; -68,13; 48,26; 118,14; 34,37     
-76,66; -63,78; 74,43; -135,41; 88,26   
*/