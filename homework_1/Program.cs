void Task2()
{
    //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
        Console.Write("Первое число большее. ");
        Console.Write("Второе число меньшее. ");
    }
    else if (a < b)
    {
        Console.Write("Второе число большее. ");
        Console.Write("Первое число меньшее. ");
    }
    else
    {
        Console.Write("Числа равны. ");
    }
}

void Task4()
{
    //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;

    if (max < b)
    {
        max = b;
    }
    if (max < c)
    {
        max = c;
    }

    Console.Write($"Максимальное число {max}");
}

void Task6()
{
    //Напишите программу, которая на вход принимает число и выдаёт,
    //является ли число чётным (делится ли оно на два без остатка).

    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0)
    {
        Console.Write("Число четное");
    }
    else
    {
        Console.Write("Число нечетное");
    }
    
}
Task6();