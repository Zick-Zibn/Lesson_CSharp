try
{
    Console.Write("Введите начальное число: ");
    int startNumber = int.Parse(Console.ReadLine()??"");

    Console.Write("Введите конечное число: ");
    int endNumber = int.Parse(Console.ReadLine()??"");

    if (endNumber < startNumber)
        throw new Exception("Конечное число не может быть меньше начального");
    else if (endNumber == startNumber)
        throw new Exception("Нечего рассчитывать");

    Console.WriteLine($"Сумма чисел от {startNumber} до {endNumber} равна {CalcSumBetweenTwoNumbers(startNumber, endNumber)}");

    int CalcSumBetweenTwoNumbers(int start, int end)
    {
        if (start == end)
            return start;

        return start + CalcSumBetweenTwoNumbers(start + 1, end);
    }

}
catch (System.Exception exc)
{    
    Console.WriteLine(exc.Message);
}
/*
Введите начальное число: 3
Введите конечное число: 10
Сумма чисел от 3 до 10 равна 52
*/