using System;

/*
 * Задание 1
Напишите метод, который отображает квадрат из 
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.

 * Задание 2
Напишите метод, который проверяет является ли 
переданное число «палиндромом». Число передаётся в 
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как 
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.

 * Задание 3
Напишите метод, фильтрующий массив на основании 
переданных параметров. Метод принимает параметры: 
оригинальный_массив, массив_с_данными_для_фильтрации.
Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 -1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 -1 — результат работы метода.

 * Задание 4
Создайте класс «Веб-сайт». Необходимо хранить в 
полях класса: название сайта, путь к сайту, описание 
сайта, ip адрес сайта. Реализуйте методы класса для ввода 
данных, вывода данных, реализуйте доступ к отдельным 
полям через методы класса. 

 * Задание 5
Создайте класс «Журнал». Необходимо хранить в 
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.

 * Задание 6
Создайте класс «Магазин». Необходимо хранить в 
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
Реализуйте методы класса для ввода данных, вывода 
данных, реализуйте доступ к отдельным полям через 
методы класса.
*/


using System.Globalization;

namespace Classes
{
    internal class Program
    {
        static void Function1()
        {
            char symbol;
            int length;


            Console.Write("Введите длину стороны квадрата: ");
            length = int.Parse(Console.ReadLine());

            Console.Write("Введите символ из которого будет состоять квадрат: ");
            symbol = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("\nВаш квадрат: ");
            for (int j = 0; j < length; ++j) // вывод первой строки
            {
                Console.Write(symbol + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < length - 2; ++i) // вывод внутренних строк
            { 
                Console.Write(symbol);
                for (int l = 0; l < (length * 2) - 3; ++l)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(symbol);
            }

            for (int j = 0; j < length; ++j) // вывод последней строки
            {
                Console.Write(symbol + " ");
            }
        }



        static bool Function2()
        {
            string number;

            Console.Write("Введите число: ");
            number = Console.ReadLine();

            for (int i = 0; i < number.Length; ++i)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    // Console.WriteLine($"{number[i]} != {number[number.Length - i - 1]}");
                    return false;
                }
                // Console.WriteLine($"{number[i]} == {number[number.Length - i - 1]}");
            }
            return true;
        }



        static void Function3(int[] array, int[] array_filter)
        {
            int[] new_array = new int[array.Length];

            Console.Write("Исходный массив: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.Write("\nМассив с фильтрами: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array_filter.Length; ++j)
                {

                    if (array[i] == array_filter[j])
                    {
                        break;
                    }

                    if (j == array.Length - 4)
                    {
                        Array.Fill(new_array, array[i]);
                    }
                }

            }

            Console.Write("\nИзменённый массив: ");
            for (int i = 0; i < new_array.Length; ++i)
            {
                Console.Write(new_array[i] + " ");
            }
        }



        static void Function4()
        {

        }



        static void Function5()
        {

        }



        static void Function6()
        {

        }




        static void Main()
        {
            //Function1();
            //if (Function2() == true) { Console.WriteLine("Введённое число является палиндромом"); } else { Console.WriteLine("Введённое число не является палиндромом"); };
            int[] array = { 1, 2, 3, 4, 5 }; int[] array_filter = { 2, 4 }; Function3(array, array_filter);
            Function4();
            Function5();
            Function6();

        }
    }
}