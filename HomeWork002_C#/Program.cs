﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков


// Console.WriteLine("Введите трёхзначное число: ");
// string num = Console.ReadLine()!;

// if (num.Length!=3)
// {
//     Console.WriteLine("Введено неверное число!");
// }

// else
// {
//     Console.WriteLine($"вторая цифра {num[1]}");
// }






// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000


// Console.WriteLine("Введите число: ");
// string numb = (Console.ReadLine()!);
// if (numb.Length < 0 || numb.Length > 5)
// {
//     Console.WriteLine("Введено слишком большое число");
// }
// else
// {
//     if (numb.Length < 3)
//     {
//         Console.WriteLine("Третей цифры нет");
//     }
//     else
//     {
//         Console.WriteLine($"Третья цифра заданного числа: {numb[2]}");
//     }
// }





//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7


Console.WriteLine("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day < 1 || day > 7)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной день!");
    }
    else
    {
        Console.WriteLine("Это НЕ выходной день");
    }
}




