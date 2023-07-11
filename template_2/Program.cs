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

        void Task17()
        {
            // 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
            // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int x = Input("Введите x: ");
            int y = Input("Введите y: ");

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка принадлежит 1 четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка принадлежит 2 четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка принадлежит 3 четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка принадлежит 4 четверти");
            }
            else
            {
                Console.WriteLine("Точка лежит на оси");
            }
        }
        void Task18()
        {
            // 18.  Напишите программу, которая по заданному номеру четверти, показывает 
            // диапазон возможных координат точек в этой четверти (x и y).

            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int a = Input("Введите номер четверти: ");

            if (a == 1)
            {
                Console.WriteLine("x > 0 и y > 0");
            }
            else if (a == 2)
            {
                Console.WriteLine("x < 0 и y > 0");
            }
            else if (a == 3)
            {
                Console.WriteLine("x < 0 и y < 0");
            }
            else if (a == 4)
            {
                Console.WriteLine("x > 0 и y < 0");
            }
            else
            {
                Console.WriteLine("Нет такой оси");
            }
        }

        void Task21()
        {
            // 21.  Напишите программу, которая принимает на вход координаты двух точек 
            // и находит расстояние между ними в 2D пространстве.


            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int x1 = Input("Введите x первой точки: ");
            int y1 = Input("Введите y первой точки: ");
            int x2 = Input("Введите x второй точки: ");
            int y2 = Input("Введите y второй точки: ");

            double dist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            dist = Math.Round(dist, 2);

            Console.WriteLine($"Расстояние между точками = {dist}.");
        }

        void Task22()
        {
            // 22.  Напишите программу, которая принимает на вход число (N) 
            //и выдаёт таблицу квадратов чисел от 1 до N.


            int Input(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());
            }
            int a = Input("Введите число: ");

            //while (counter <= a)
            //{
            //   Console.Write($"{counter*counter}, ");
            //  counter++;
            // }
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }

        }

        // Task9();
        // Task11();
        // Task12();
        // Task14();
        // Task16();
        // Task17();
        // Task18();
        // Task21();
        // Task22();
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        int task = Input("Введите номер задачи: ");
        switch (task)
        {
            case 17:
                Task17();
                break;
            case 18:
                Task18();
                break;
            case 21:
                Task21();
                break;
            case 22:
                Task22();
                break;
            case 9:
                Task9();
                break;
            case 11:
                Task11();
                break;
            case 12:
                Task12();
                break;
            case 14:
                Task14();
                break;

            default:
                Console.WriteLine("Нет такой задачи");
                break;
        }

    }


}

