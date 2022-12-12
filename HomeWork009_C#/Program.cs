// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(N, 1));


// string PrintNumbers(int end, int start)
// {
//     if (end == start) return end.ToString();
//     return (end + " " + PrintNumbers(end - 1, start));
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintSum(M, N));

// int PrintSum(int start, int end)
// {
//     if (start == end) return start;
//     return (start += PrintSum(start + 1, end));
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(AckermanFunc(M, N));

int AckermanFunc(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M > 0 && N == 0)
    {
        return AckermanFunc(M - 1, 1);
    }
    else
    {
        return AckermanFunc(M - 1, AckermanFunc(M, N - 1));
    }
}