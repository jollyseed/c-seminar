void Task25()
{
// Задача 25: Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message)
{
    System.Console.Write(message); //выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); //вводим значение
    int result = int.Parse(readInput); //приводим к числу
    return result; //выводим результат

}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine ($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}
}

void Task27()
{
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message); //выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); //вводим значение
    int result = int.Parse(readInput); //приводим к числу
    return result; //выводим результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number%10;
        number /=10;
    }
    return result;
}
int number = Prompt("Введите число: ");
System.Console.WriteLine  ($"Сумма всех числе в цифре {number} = {SumAllDigit(number)}");
}

Task27();
