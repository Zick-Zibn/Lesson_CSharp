Console.Write("Сколько чисел будет введено: ");
int qtyNumber = int.Parse(Console.ReadLine()??"");
int[] array  = InitArray(qtyNumber);

Console.WriteLine($"{String.Join(",", array)} -> {CountPositiveNumber(array)}");

int[] InitArray(int qtyNumber)
{
    int[] array = new int[qtyNumber];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine()??"");
    }
    return array;
}

int CountPositiveNumber(int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            counter++;
    }
    return counter;
}