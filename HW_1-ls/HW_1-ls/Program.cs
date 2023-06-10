/*
 Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
 
 */


//int firstNum  = 0;
//int secondNum = 0;

//Console.Write("Введите первое число: ");
//firstNum = int.Parse(Console.ReadLine());

//Console.Write("Введите второу число: ");
//secondNum = int.Parse(Console.ReadLine())!;

//if (firstNum > secondNum)
//{
//    Console.WriteLine($"Максимальное число: {firstNum}");
//}
//else
//{
//    Console.WriteLine($"Максимальное число: {secondNum}");
//} // 17 строк 


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 
 */

//int firstNum = 0;
//int secondNum = 0;
//int thirdNum = 0;
//int answer = 0;

//Console.Write("Введите первое число: ");
//firstNum = int.Parse(Console.ReadLine());

//Console.Write("Введите второе число: ");
//secondNum = int.Parse(Console.ReadLine());

//Console.Write("Введите второе число: ");
//thirdNum = int.Parse(Console.ReadLine());

//answer = firstNum > secondNum && firstNum > thirdNum ? firstNum : secondNum; // проверка, 1 число больше второго и 1 число больше 3? 
//answer = secondNum > thirdNum ? answer : thirdNum; // проверка, 2 число больше 3? 

//Console.WriteLine(answer);
//18 строк 

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
 
 */


//int value = 0;

//Console.Write("Введите число для проверки: ");
//value = int.Parse(Console.ReadLine());

//if (value % 2 == 0)
//{
//    Console.WriteLine($"Ваше число {value} является четным");
//}
//else
//{ 
//    Console.WriteLine($"Ваше число {value} не является четным");
//}
//13 строк


/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
 
 */


int value = 0;
int answer= 0;

Console.Write("Введите ваше число: ");
value = int.Parse(Console.ReadLine());

for (int i = 0; i < value; ++i)
{
    if (i % 2 == 0)
    { 
        answer = i;
        Console.Write($"{answer} ");
    }
}
//14 строк 
