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
        Console.WriteLine("Число не трехзначное");
    }
    
    
}
void Task13()
{
    // Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    int a = Input("Введите число: ");
    a = Math.Abs(a);
    if (a > 99)
    {
        while (a > 999)
        {
            a /= 10;
        }
        Console.WriteLine($"Третья цифра числа: {a % 10}");
    }
    else 
    {
        Console.WriteLine("Третьей цифры нет");
    }
   
}
void Task15()
    {
        // Напишите программу, которая принимает на вход цифру, 
        // обозначающую день недели, и проверяет, является ли этот день выходным.
        int a = Input("Введите номер дня недели: ");

        if ( a > 1 && a <= 5)
        {
            Console.WriteLine("Будний день");
        }
        else if ( a == 6 || a == 7)
        {
            Console.WriteLine("Выходной");
        }
        else 
        {
            Console.WriteLine("Введите цифру от 1 до 7");
        }
    }
// Task10();
// Task13();
Task15();
