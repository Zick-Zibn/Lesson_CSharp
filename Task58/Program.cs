int qtyCollumns_A_RowsMatrix_B = 0, qtyRowsMatrix_A = 0, qtyColumnsMatrix_B = 0;
Console.Clear();
GetDataFromUser(ref qtyCollumns_A_RowsMatrix_B, ref qtyRowsMatrix_A, ref qtyColumnsMatrix_B);

int[,] matrix_A = InitArray(qtyRowsMatrix_A, qtyCollumns_A_RowsMatrix_B);
int[,] matrix_B = InitArray(qtyCollumns_A_RowsMatrix_B, qtyColumnsMatrix_B);

Console.WriteLine("Матрица А");
PrintArray(matrix_A);
Console.WriteLine();
Console.WriteLine("Матрица B");
PrintArray(matrix_B);
Console.WriteLine();
Console.WriteLine("Матрица результат");
int[,] resMartix = ResultingMatrix(matrix_A, matrix_B);
PrintArray(resMartix);

void GetDataFromUser(ref int qtyCollumns_A_RowsMatrix_B, ref int qtyRowsMatrix_A, ref int qtyColumnsMatrix_B)
{
    bool inputWrong = false;

    while (true)
    {
        try
        {
            inputWrong = false;

            Console.Write("Введите число столбцов матрицы А и число строк матрицы В: ");
            qtyCollumns_A_RowsMatrix_B = int.Parse(Console.ReadLine() ?? "");

            if (qtyCollumns_A_RowsMatrix_B <= 0)
            {
                inputWrong = true;
                throw new Exception(ErrorText());
            }
            Console.Write("Введите число строк матрицы А: ");
            qtyRowsMatrix_A = int.Parse(Console.ReadLine() ?? "");

            if (qtyRowsMatrix_A <= 0)
            {
                inputWrong = true;
                throw new Exception(ErrorText());
            }
            Console.Write("Введите число столбцов матрицы В: ");
            qtyColumnsMatrix_B = int.Parse(Console.ReadLine() ?? "");

            if (qtyRowsMatrix_A <= 0)
            {
                inputWrong = true;
                throw new Exception(ErrorText());
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
string ErrorText()
{
    return "Введенное значение не может быть меньше или равно нулю";
}

int[,] InitArray(int arrayRows, int arrayColumns)
{
    int[,] array = new int[arrayRows, arrayColumns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = new Random().Next(1, 11);
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
            Console.Write($"{inArray[i, k]} ");
        }
        Console.WriteLine();
    }
}

int[,] ResultingMatrix(int[,] matrix_A, int[,] matrix_B)
{
    int[,] resultMatrix = new int[matrix_A.GetLength(0), matrix_B.GetLength(1)];

    for (int i = 0; i < matrix_A.GetLength(0); i++)
    {
        for (int j = 0; j < matrix_B.GetLength(1); j++)
        {                             
            for (int k = 0; k < matrix_B.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix_A[i, k] * matrix_B[k, j];   
            }
        }
    }
    return resultMatrix;
}
/*
Введите число столбцов матрицы А и число строк матрицы В: 3
Введите число строк матрицы А: 2
Введите число столбцов матрицы В: 3
Матрица А        
2 8 6
2 1 10

Матрица B        
3 7 6
10 7 1
1 6 7

Матрица результат
92 106 62        
26 81 83
*/
