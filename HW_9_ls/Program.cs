
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());

rec(n);
Console.WriteLine();
exam_and_rec_sum(n, m);
Console.WriteLine();
Console.WriteLine(accerman(m, n));


void rec(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write($"{n }");
    rec(n - 1);
}


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

void exam_and_rec_sum(int n, int m)
{
    int a = n;
    int b = m;

    if (a < b)
    {
        Console.Write(rec_sum(a, b));
        return;
    }
    else if (a == b)
    {
        Console.Write("Ошибка");
        return;
    }
    else
    {
        Console.Write(rec_sum(b, a));
        return;
    }
}
int rec_sum(int a, int b)
{
    int temp = a;
    if (a == b)
    {
        return temp;
    }
    
    return temp += rec_sum(++a, b);
}

int accerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return accerman(m - 1, 1);
    }
    else 
    { 
        return accerman(m - 1, accerman(m, n - 1));
    }
}


