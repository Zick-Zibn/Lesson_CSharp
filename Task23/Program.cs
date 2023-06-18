int     number;
int     i = 1;
string  value;
bool    canParse;

Console.Clear();

while (true)
{
    Console.WriteLine("Введите число: ");
    value = Console.ReadLine()?? "";
    canParse = int.TryParse(value, out number);

    if (canParse)
    {
        Console.Write($"{number} -> ");

        while (i <= number)
        {
            Console.Write("{0}{1}", numberCube(i), i != number ? ", " : "");
            i++;
        }
        break;
    }
    else
        Console.WriteLine("Введеное значение не является числом");
}

static int numberCube(int i)
{
    return Convert.ToInt32(Math.Pow(i, 3));
}