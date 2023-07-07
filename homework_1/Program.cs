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
    Task2();