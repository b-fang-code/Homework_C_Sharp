// // ЗАДАЧА 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе  число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2)
{
    Console.Write($"Большее число {num1} , а меньшее число {num2}");
}
else
{
    Console.Write($"Большее число {num2} , а меньшее число {num1}");
}

*/

// ЗАДАЧА 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write($"Максимальное число {max} ");

*/

// ЗАДАЧА 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.Write($"Число {a} - чётное");
}
else
{
    Console.Write($"Число {a} - нечётное");
}

*/

// ЗАДАЧА 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = 1;
while (N2 <= N)
{
    if (N2%2==0)
    Console.Write($"{N2} ");
    N2++;
}







