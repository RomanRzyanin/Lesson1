//task1

// int a = 876;
// int first_digit = a / 100;
// int third_digit = a % 10;
// int res = first_digit * 10 + third_digit;
// Console.WriteLine($"Результат от числа {a} => {res}");

//task2

// int number = 482;
// int second_digit = number / 10 % 10;
// int third_digit = number % 10;
// int res = (int)Math.Pow(second_digit, third_digit);
// Console.WriteLine($"{second_digit} ^ {third_digit} => {res}");

//task4*
// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

int number = 482;
if(number < 100)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    int res = number / 100 % 10;
    Console.WriteLine($"Третья цифра с конца {res}");
}

// int count = 0;
//     while (count < 2) {
//         number /= 10;
//         count++;
//     }