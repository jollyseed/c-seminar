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
void Task21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    int x1 = Input("Введите x первой точки: ");
    int y1 = Input("Введите y первой точки: ");
    int z1 = Input("Введите z первой точки: ");
    int x2 = Input("Введите x второй точки: ");
    int y2 = Input("Введите y второй точки: ");
    int z2 = Input("Введите z второй точки: ");

    double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    dist = Math.Round(dist, 2);

    Console.WriteLine($"Расстояние между точками = {dist}.");
}
// Task19();
Task21();