double k1 = 0, k2 = 0, b1 = 0, b2 = 0;
double pointX = 0, pointY = 0;

GetDataFromUser(ref k1, ref k2, ref b1, ref b2);
CalcPoint(ref pointX, ref pointY);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({pointX}; {pointY})");

void GetDataFromUser(ref double k1, ref double k2, ref double b1, ref double b2)
{
    while (true)
    {
        try
        {
            Console.Write("Введите координаты точки B1: ");
            b1 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите координаты точки K1: ");
            k1 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите координаты точки B2: ");
            b2 = double.Parse(Console.ReadLine() ?? "");

            Console.Write("Введите координаты точки K2: ");
            k2 = double.Parse(Console.ReadLine() ?? "");

            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine("Невозможно пребразовать введенное значение в число {0}", exc.Message);
        }
    }
}

void CalcPoint(ref double x, ref double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}