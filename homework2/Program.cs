﻿//Task1. Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// int number = 161;
// int divider1 = 7;
// int divider2 = 23;
// if (number % divider1 == 0 && number % divider2 == 0)
// {
//     Console.WriteLine($"Число {number} кратно {divider1} и {divider2} ");
// }
// if (number % divider1 != 0 && number % divider2 == 0)
// {
//     Console.WriteLine($"Число {number} кратно {divider2} ");
// }
// if (number % divider1 == 0 && number % divider2 != 0)
// {
//     Console.WriteLine($"Число {number} кратно {divider1} ");
// }
// if (number % divider1 != 0 && number % divider2 != 0)
// {
//     Console.WriteLine($"Число {number} не делиться без остатка на  {divider1} и {divider2} ");
// }

//Task2    Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// int x = 0;
// int y = -7;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  I четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться во  II четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  III четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  IV четверти");
// }
// else
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться находиться на оси координат");
// }

//Task3     Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// int number = 17;
// if (number > 9 && number < 100)
// {
//     int first_digit = number / 10;
//     int second_digit = number % 10;
//     if (first_digit  > second_digit)
//     {
//         Console.WriteLine($"Наибольшая цифра {first_digit}");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшая цифра {second_digit}");
//     }
// }
// else
// {
//     Console.WriteLine("Число не двузначное!");
// }

//Task4   Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

// int number = 123456789;
// string myString = number.ToString();  //Перевод числа в строку
// int length = myString.Length;         //Нахождение длины строки
// //int digit_count = (int)Math.Log10(number) + 1; //Нахождение длины числа через десятичный логарифм (один из вариантов)
// int x = length -1;  //Переменная для вычисления степени
// int i = 0;          //Переменная для счетчика цикла
// while (i < length)
// {
//     int res  = number / (int)Math.Pow(10, x); //Вычисление первой цифры в числе
//     if (i >= 0 && i < length - 1)
//     {
//         Console.Write($"{res}, ");
//     }
//     else
//     {
//         Console.Write(res);
//     }
//     number = number - (res * (int)Math.Pow(10, x)); // Определение нового числа без первой цифры
//     x--;
//     i++;
// }

// Задача из эталонных решений
// using System;
//     class Program   
//         {
//             static void Main()
//                 {
//                     Console.Write("Введите натуральное число N: ");
//                     int N = Convert.ToInt32(Console.ReadLine());
//                     if (N < 10)
//                     {
//                         Console.WriteLine(N);
//                     }
//                     else
//                     {
//                         while (N > 0)
//                         {
//                             int currentDigit = N % 10;
//                             N /= 10;
//                             if (N > 0)
//                             {
//                                 Console.Write(currentDigit + ",");
//                             }
//                             else
//                             {
//                                 Console.WriteLine(currentDigit);
//                             }
//                         }
//                     }
//                 }
//         }