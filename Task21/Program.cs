int x1 = 0, y1 = 0, z1 = 0; 
int x2 = 0, y2 = 0, z2 = 0;
double distanse;

initCoordinates(ref x1, ref x2, ref y1, ref y2, ref z1, ref z2);

distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между двумя точками A({x1}, {y1}, {z1}):B({x2},{y2},{z2}) в 3D пространстве составляет {distanse:f2}");

static void initCoordinates(ref int x1, ref int x2, ref int y1, ref int y2, ref int z1, ref int z2)
{
    while (true)
    {
        try
        {
            //Console.Clear();
            Console.Write("Введите X1: ");
            x1 = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите Y1: ");
            y1 = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите Z1: ");
            z1 = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите X2: ");
            x2 = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите Y2: ");
            y2 = int.Parse(Console.ReadLine()??"");

            Console.Write("Введите Z2: ");
            z2 = int.Parse(Console.ReadLine()??"");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода координат {exc.Message}");
            //return;
        }
    }
}