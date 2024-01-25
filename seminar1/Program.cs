// Первый код на C#:seminar1
/* Многосточный 
комментарий
*/
/*
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет
*/
// camelCase: firstNumber
// snakeCase: first_number

//Task_1

// int first_number = 30;
// int second_number = 5;

// if (second_number * second_number == first_number)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

//Task_2

// int N = 4;
// int negativeN = -N;
// while (negativeN <= N)
// {
//     Console.Write(negativeN + " "); //Конкатенация
//     negativeN++; //инкремент negativeN = negativeN + 1 
//}

//Task3

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

int number = 435; //4 + 5 = 9
int first_digit = number / 100;
int third_digit = number % 10;
int res = first_digit + third_digit;
Console.WriteLine("Result: " + res);


