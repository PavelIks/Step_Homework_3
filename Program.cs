using System;
using System.Security.Cryptography.X509Certificates;

namespace Step_Homework_3
{
    class Program
    {
        /*Домашнее задание №4*/
        static void Main(string[] args)
        {
            /*Встреча №7*/
            /*Задание 1: Пользователь вводит с клавиатуры целое шестизначное число.
            Написать программу, которая определяет, является ли введенное число –
            счастливым (Счастливым считается шестизначное число, у которого сумма
            первых 3 цифр равна сумме вторых трех цифр). Если пользователь ввел не
            шестизначное число – сообщение об ошибке.*/

            /*Console.Write("Введите 6-изначное число: ");
            string X = Console.ReadLine();
            if(Convert.ToInt32(X) > (Convert.ToInt32(X) % 1000000))
            {
                Console.WriteLine("Число - не 6-изначное (введено более 6 символов)");
            }
            else if (X.Length != 6)
            {
                Console.WriteLine("Число - не 6-изначное (введено менее 6 символов)");
            }
            else
            {
                Console.WriteLine("Число - 6-изначное");
                int A1 = Convert.ToInt32(X) / 100000;
                int A2 = Convert.ToInt32(X) / 10000 % 10;
                int A3 = Convert.ToInt32(X) / 1000 % 10;
                int A4 = Convert.ToInt32(X) % 1000 / 100;
                int A5 = Convert.ToInt32(X) % 100 / 10;
                int A6 = Convert.ToInt32(X) % 10;
                Console.Write(A1 + " + ");
                Console.Write(A2 + " + ");
                Console.Write(A3);
                int B1 = A1 + A2 + A3, B2 = A4 + A5 + A6;
                if(B1 == B2)
                {
                    Console.Write(" = " + A4 + " + ");
                    Console.Write(A5 + " + ");
                    Console.WriteLine(A6);
                    Console.WriteLine("Число - счастливое: " + B1 + " и " + B2 + "!");
                }
                else
                {
                    Console.Write(" != " + A4 + " + ");
                    Console.Write(A5 + " + ");
                    Console.WriteLine(A6);
                    Console.WriteLine("Число - не счастливое: " + B1 + " и " + B2 + "!");
                }
            }
            Console.ReadKey();*/


            /*Задание 2: Пользователь вводит четырехзначное число.
            Необходимо поменять в этом числе 1 и 2 цифры, а также
            3 и 4 цифры. Если пользователь вводит не четырехзначное
            число – вывести сообщение об ошибке.*/

            /*Console.Write("Введите 4-изначное число: ");
            string X = Console.ReadLine();
            if(Convert.ToInt32(X) > (Convert.ToInt32(X) % 10000))
            {
                Console.WriteLine("Число - не 4-изначное (введено более 4 символов)");
            }
            else if (X.Length != 4)
            {
                Console.WriteLine("Число - не 4-изначное (введено менее 4 символов)");
            }
            else
            {
                Console.WriteLine("Число - 4-изначное");
                int A1 = Convert.ToInt32(X) / 1000 % 10;
                int A2 = Convert.ToInt32(X) % 1000 / 100;
                int A3 = Convert.ToInt32(X) % 100 / 10;
                int A4 = Convert.ToInt32(X) % 10;
                Console.Write(X + " | ");
                Console.Write(A2);
                Console.Write(A1);
                Console.Write(A4);
                Console.Write(A3);
            }
            Console.ReadKey();*/


            /*Задание 3: Пользователь вводит с клавиатуры 7 целых чисел.
            Напишите программу, которая определяет максимальное из этих
            7 чисел (Подсказка – решение должно быть простым).*/

            /*Console.Write("Enter X1: ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X2: ");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X3: ");
            int A3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X4: ");
            int A4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X5: ");
            int A5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X6: ");
            int A6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter X7: ");
            int A7 = Convert.ToInt32(Console.ReadLine());
            int[] A = { A1, A2, A3, A4, A5, A6, A7 };
            int max_numb = A.Max();
            Console.WriteLine("Самое большое число - " + max_numb);
            Console.ReadKey();*/


            /*Задание 4: Грузовой самолет должен пролететь с грузом из пункта А в пункт С через пункт В.
            Емкость бака для топлива у самолета – 300 литров. Потребление топлива на 1 км в зависимости
            от веса груза у самолета следующее:
            - до 500 кг: 1 литров / км
            - до 1000 кг: 4 литров / км
            - до 1500 кг: 7 литров / км
            - до 2000 кг: 9 литров / км.
            - более 2000 кг – самолет не поднимает.
            Пользователь вводит расстояние между пунктами А и В, и расстояние между пунктами В и С, а
            также вес груза. Программа должна рассчитать какое минимальное количество топлива
            необходимо для дозаправки самолету в пункте В, чтобы долететь из пункта А в пункт С. В
            случае невозможности преодолеть любое из расстояний – программа должна вывести
            сообщение о невозможности полета по введенному маршруту.*/

            /*Console.Write("Введите A-B: ");
            int AB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B-C: ");
            int BC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кг. груза: ");
            int Cargo_Weight = Convert.ToInt32(Console.ReadLine());
            if (Cargo_Weight <= 500)
            {
                int Fuel_quantity_required_AB = AB * 1;
                if (Fuel_quantity_required_AB < 300)
                {
                    Console.WriteLine("Самолёт долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int Fuel_quantity_required_BC = BC * 1;
                if (Fuel_quantity_required_BC < 300)
                {
                    Console.WriteLine("Самолёт долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int x = Fuel_quantity_required_BC + Fuel_quantity_required_AB;
                Console.WriteLine("Самолёту нужно " + x + " л. топлива.");
            }
            else if(Cargo_Weight <= 1000)
            {
                int Fuel_quantity_required_AB = AB * 4;
                if (Fuel_quantity_required_AB < 300)
                {
                    Console.WriteLine("Самолёт долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int Fuel_quantity_required_BC = BC * 4;
                if (Fuel_quantity_required_BC < 300)
                {
                    Console.WriteLine("Самолёт долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int x = Fuel_quantity_required_BC + Fuel_quantity_required_AB;
                Console.WriteLine("Самолёту нужно " + x + " л. топлива.");
            }
            else if (Cargo_Weight <= 1500)
            {
                int Fuel_quantity_required_AB = AB * 7;
                if (Fuel_quantity_required_AB < 300)
                {
                    Console.WriteLine("Самолёт долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int Fuel_quantity_required_BC = BC * 7;
                if (Fuel_quantity_required_BC < 300)
                {
                    Console.WriteLine("Самолёт долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int x = Fuel_quantity_required_BC + Fuel_quantity_required_AB;
                Console.WriteLine("Самолёту нужно " + x + " л. топлива.");
            }
            else if (Cargo_Weight <= 2000)
            {
                int Fuel_quantity_required_AB = AB * 9;
                if (Fuel_quantity_required_AB < 300)
                {
                    Console.WriteLine("Самолёт долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до B (" + Fuel_quantity_required_AB + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int Fuel_quantity_required_BC = BC * 9;
                if (Fuel_quantity_required_BC < 300)
                {
                    Console.WriteLine("Самолёт долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно).");
                }
                else
                {
                    Console.WriteLine("Самолёт не долетит до C (" + Fuel_quantity_required_BC + " л. топлива нужно - лимит превышен).");
                    Console.WriteLine("Ёмкость топливного бака самолёта - 300 л.");
                }
                int x = Fuel_quantity_required_BC + Fuel_quantity_required_AB;
                Console.WriteLine("Самолёту нужно " + x + " л. топлива.");
            }
            else
            {
                Console.WriteLine("Самолёт не поднимает");
            }
            Console.ReadKey();*/


            /*Встреча №8*/
            /*Задание 1: Пользователь вводит две даты (день, месяц, год в виде целых чисел). Необходимо
            определить и вывести количество дней между этими двумя датами. Для расчетов учитывать
            високосные года, а также корректное число дней в месяцах (март – 31, сентябрь – 30, февраль
            не високосного года – 28 и т.д.)*/

            Console.Write("Введите 1-ю дату - день: ");
            int w_day_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1-ю дату - месяц: ");
            int w_month_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1-ю дату - год: ");
            int w_year_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2-ю дату - день: ");
            int w_day_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ю дату - месяц: ");
            int w_month_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ю дату - год: ");
            int w_year_2 = Convert.ToInt32(Console.ReadLine());

            int a1 = w_year_1 / 4 - w_year_1 / 100 + w_year_1 / 400;
            int a2 = w_year_2 / 4 - w_year_2 / 100 + w_year_2 / 400;
            int a = a1 - a2;

            if (w_month_1 > 12 || w_month_2 > 12)
            {
                Console.WriteLine("Месяцев менее 12!");
            }
            else if (w_month_1 == 1 || w_month_2 == 1)
            {
                int month_1 = 31;
                if (w_day_1 > month_1 || w_day_2 > month_1)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;
                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;
                    int date = date1 - date2;
                    Console.WriteLine(date + a);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 2 || w_month_2 == 2)
            {
                int month_2 = 28;
                if (w_day_1 > month_2 || w_day_2 > month_2)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 3 || w_month_2 == 3)
            {
                int month_3 = 31;
                if (w_day_1 > month_3 || w_day_2 > month_3)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 4 || w_month_2 == 4)
            {
                int month_4 = 31;
                if (w_day_1 > month_4 || w_day_2 > month_4)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 5 || w_month_2 == 5)
            {
                int month_5 = 31;
                if (w_day_1 > month_5 || w_day_2 > month_5)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 6 || w_month_2 == 6)
            {
                int month_6 = 30;
                if (w_day_1 > month_6 || w_day_2 > month_6)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 7 || w_month_2 == 7)
            {
                int month_7 = 31;
                if (w_day_1 > month_7 || w_day_2 > month_7)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 8 || w_month_2 == 8)
            {
                int month_8 = 30;
                if (w_day_1 > month_8 || w_day_2 > month_8)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 9 || w_month_2 == 9)
            {
                int month_9 = 31;
                if (w_day_1 > month_9 || w_day_2 > month_9)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 10 || w_month_2 == 10)
            {
                int month_10 = 31;
                if (w_day_1 > month_10 || w_day_2 > month_10)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 11 || w_month_2 == 11)
            {
                int month_11 = 30;
                if (w_day_1 > month_11 || w_day_2 > month_11)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
            else if (w_month_1 == 12 || w_month_2 == 12)
            {
                int month_12 = 31;
                if (w_day_1 > month_12 || w_day_2 > month_12)
                {
                    Console.WriteLine("Достигнут лимит дней!");
                    Console.ReadKey();
                }
                else
                {
                    w_year_1 = w_year_1 * 365;
                    w_year_2 = w_year_2 * 365;

                    int date1 = w_day_1 + w_year_1;
                    int date2 = w_day_2 + w_year_2;

                    Console.WriteLine(date1 - date2);
                    Console.ReadKey();
                }
            }
        }
    }
}