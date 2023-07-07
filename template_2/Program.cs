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



        void Task11()
        {
            // 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

            Random rnd = new Random();

            int number = rnd.Next(100, 1000);
            Console.WriteLine($"Выпало случайное число: {number}");

            int f_digit = number / 100;
            int t_digit = number % 10;

            Console.WriteLine($"{f_digit}{t_digit}");
        }

        void Task14()
        {
            //14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 && num % 23 == 0)
            {
                Console.WriteLine("Число кратно 7 и 23");
            }
            else
            {
                Console.WriteLine($"Число не кратно 7 или 23.");

            }
        }


        void Task12()
        {
            // 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
            //является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            int number_f = Input("Введите первое число: ");
            int number_s = Input("Введите второе число: ");
            int div = number_s % number_f;

            if (div == 0)
            {
                Console.WriteLine($"Число {number_s} кратно {number_f}");
            }
            else
            {
                Console.WriteLine($"Число {number_s} НЕ кратно {number_f}."
                                 + $" Остаток от деления равен {div}");
            }
        }


        void Task16()
        {
            // 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
            //квадратом другого.

            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            int number_f = Input("Введите первое число: ");
            int number_s = Input("Введите второе число: ");


            if (number_f == number_s * number_s)
            {
                Console.WriteLine($"Число {number_f} является квадратом {number_s}");
            }
            else if (number_s == number_f * number_f)
                {
                Console.WriteLine($"Число {number_s} является квадратом {number_f}");
                }
                else Console.WriteLine($"Числа {number_f} и {number_s} не являются квадратами друг друга");

        }

         

        void Task16_1()
        {
            // 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число 
            //квадратом другого.

            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }

            int number_f = Input("Введите первое число: ");
            int number_s = Input("Введите второе число: ");


            if (number_f == number_s * number_s || number_s == number_f * number_f)
            {
                Console.WriteLine("Является квадратом");
            }
            else Console.WriteLine("НЕ является квадратом");

        }

        Task16_1();

    }


}

