int x = 0, y = 0, z = 0;

GetDataFromUser(ref x, ref y, ref z);
int[,,] array = InitArray(x, y, z);

PrintArray(array);

void GetDataFromUser(ref int x, ref int y, ref int z)
{
    bool inputWrong = false;

    while (true)
    {
        try
        {
            inputWrong = false;

            Console.Write("Введите количество элементов X: ");
            x = int.Parse(Console.ReadLine() ?? "");

            if (x <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество элементов X не может быть меньше или равно нулю");
            }

            Console.Write("Введите количество элементов Y: ");
            y = int.Parse(Console.ReadLine() ?? "");

            if (y <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество элементов Y не может быть меньше или равно нулю");
            }

            Console.Write("Введите количество элементов Z: ");
            z = int.Parse(Console.ReadLine() ?? "");

            if (z <= 0)
            {
                inputWrong = true;
                throw new Exception("Количество элементов Z не может быть меньше или равно нулю");
            }

            if (x * y * z > 99)
            {
                inputWrong = true;
                throw new Exception("Заданный размер массива превышает максимально возможное количество уникальных элементов массива");
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

int[,,] InitArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int[] unicValueArray = new int[x * y * z];
    int genValue = 0;
    int cnt  = 0;;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                    genValue = GenerateValue(unicValueArray);
                    array[i, k, j] = genValue;   
                    unicValueArray[cnt] = genValue;
                    cnt++;
            }
        }
    }
    return array;
}
 int GenerateValue(int[] array)
 {
    int value = 0; 
    bool useNumber = false;

    while (!useNumber)
    {
        value = new Random().Next(10, 100);

        if (!array.Contains(value))
            useNumber = true;
    }
    return value;
 }

 void PrintArray(int[,,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i, k, j]}({i},{k},{j}) \t");
            }
            Console.WriteLine();
        }
    }
 }