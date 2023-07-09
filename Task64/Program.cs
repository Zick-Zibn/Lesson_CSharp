try
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()??"");

    Console.WriteLine($"{number} -> {CountNumbersToValue(number)}");

    string CountNumbersToValue(int num)
    {
        if (num == 1)
            return num.ToString();
    
        return num.ToString() + " " + CountNumbersToValue(num - 1);          
    }
}
catch (Exception exc)
{
    Console.Write(exc.Message);
}      

