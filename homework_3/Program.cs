int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task19()
{
    // 19  Напишите программу, которая принимает на вход число (N) 
    //и выдаёт таблицу квадратов чисел от 1 до N.
    int main = Input("Введите пятизначное число: ");
    int a = main / 10000;
    int b = main % 10;
    int c = main / 1000 % 10;
    int d = main / 10 % 10;

    if (main > 9999 && main < 100000 && a == b && c == d)
    {
        Console.WriteLine($"Число {main} - палиндромом");
    }
    else if (main < 9999 || main > 99999)
    {
        Console.WriteLine("Число не пятизначное");
    }
    else
    {
        Console.WriteLine($"Число {main} - не палиндромом");
    }

}
// void Task()
Task19();