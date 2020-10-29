using System;

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

            /*Console.Write("Введите 1-е число: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 4-е число: ");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 5-е число: ");
            double a5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 6-е число: ");
            double a6 = Convert.ToDouble(Console.ReadLine());
            if(a1 + a2 + a3 == a4 + a5 + a6)
            {
                Console.WriteLine("Число - счастливое!");
            }
            else if
                (
                Convert.ToInt32(a1) != Convert.ToDouble(a1) ||
                Convert.ToInt32(a2) != Convert.ToDouble(a2) ||
                Convert.ToInt32(a3) != Convert.ToDouble(a3) ||
                Convert.ToInt32(a4) != Convert.ToDouble(a4) ||
                Convert.ToInt32(a5) != Convert.ToDouble(a5) ||
                Convert.ToInt32(a6) != Convert.ToDouble(a6)
                )
            {
                Console.WriteLine("Число - не целое!");
            }
            else
            {
                Console.WriteLine("Число - не счастливое!");
            }
            Console.ReadKey();*/


            /*Задание 2: Пользователь вводит четырехзначное число.
            Необходимо поменять в этом числе 1 и 2 цифры, а также
            3 и 4 цифры. Если пользователь вводит не четырехзначное
            число – вывести сообщение об ошибке.*/


            /*Console.Write("Введите 1-е число: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 4-е число: ");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a2);
            Console.WriteLine(a1);
            Console.WriteLine(a4);
            Console.WriteLine(a3);*/
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > a % 9999)
            {
                Console.WriteLine("Число - не 4-значное!");
            }
            else
            {
                Console.WriteLine(a);//
            }

            Console.ReadKey();
        }
    }
}