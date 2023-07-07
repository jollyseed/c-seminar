namespace template_2;
class Program
{
    static void Main(string[] args)
    {
       void Task9()
       {
        //9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

        Random rnd = new Random();

        int number = rnd.Next(10, 100);

        Console.WriteLine($"Выпало случайное число: {number}");

        int f_digit = number / 10;
        int s_digit = number % 10;

        if (f_digit > s_digit)
        {
            Console.WriteLine($"Наибольшая цифра числа: {f_digit}");
        }

        else Console.WriteLine($"Наибольшая цифра числа: {s_digit}");
       }

       Task9();
    }
}
