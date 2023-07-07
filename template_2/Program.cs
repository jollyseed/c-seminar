namespace template_2;
class Program
{
    static void Main(string[] args)
    {
        //9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
        
        
        Random rnd = new Random();

        int number = rnd.Next(10, 100);

        Console.WriteLine(number);
    }
}
