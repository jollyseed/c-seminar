int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task10()
{
    // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    int a = Input("Введите трехзначное число: ");
    if (a >= 100 && a < 1000)
    {
        Console.WriteLine($"Вторая цифра числа: {a / 10 % 10}");
    }
    else
    {
        Console.WriteLine($"Число не трехзначное");
    }
    
    
}
Task10();
