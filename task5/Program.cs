int Power(int number)
{
    return number * number;
}
void Task5()
{
    Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Power(num));
}

void Task7()
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int counter = -num;
while (counter <= num)
{
    Console.Write(counter + "," + " ");
    counter++;
}
}

Task7();