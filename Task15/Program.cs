int     dayWeek;
string  value;
bool    canParse;

while (true)
{    
    Console.Write("Введите номер дня недели от 1 до 7: ");

    value = Console.ReadLine()?? "";
    canParse = int.TryParse(value, out dayWeek);

    if (canParse && (dayWeek >= 1 && dayWeek <= 7))
    {
            Console.WriteLine("{0} -> {1}", dayWeek, dayWeek > 5 ? "Да" : "Нет");
            break;
    }
    else
        Console.WriteLine("Невозможно сопоставить введенное число c днём недели");
}



