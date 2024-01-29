//Task1. Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

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

// int x = 4;
// int y = -7;
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  I четверти");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться во  II четверти");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  III четверти");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine($"Точка ({x},{y}) находиться в  IV четверти");
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

int number = 2375629;
string str = number.ToString;

//int len = (int)number.ToString().Lenght;
Console.WriteLine(str);