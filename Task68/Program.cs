try
{
    Console.Write("Введите число M: ");
    int number_M = int.Parse(Console.ReadLine()??"");

    Console.Write("Введите число N: ");
    int number_N = int.Parse(Console.ReadLine()??"");

    if (number_M < 0 || number_N < 0)
        throw new Exception("Число не может быть отрицательным");

    Console.WriteLine($"m = {number_M}, n = {number_N} -> A(m, n) = {Akkerman(number_M, number_N)}");

    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
        }
    }

}
catch (System.Exception exc)
{    
    Console.WriteLine(exc.Message);
}
/*
Введите число M: 2
Введите число N: 4
m = 2, n = 4 -> A(m, n) = 11

Введите число M: 3
Введите число N: 1
m = 3, n = 1 -> A(m, n) = 13
*/