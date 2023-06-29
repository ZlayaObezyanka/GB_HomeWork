// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


//int[] FillingArr(int[] arr)
//{
//    Console.WriteLine("Барин, какие значения нужно присвоить?");
//    for (int i = 0; i < arr.Length; ++i)
//    {
//        Console.Write($"{i + 1} значение: ");
//        arr[i] = int.Parse(Console.ReadLine());
//    }
//    return arr;
//}

//int PositivNumInArr(int[] arr)
//{
//    int temp = 0;
//    for(int i = 0; i < arr.Length; ++i)
//    {
//        if(arr[i] > 0)
//        {
//            ++temp;
//        }
//    }
//return temp;
//}

//void Print(int[] arr)
//{
//    Console.WriteLine($"{string.Join(", ", arr)}");
//    Console.WriteLine($"Баринъ, у вас {PositivNumInArr(arr)} положительных указов");
//}

//Console.Write("Барин, сколько цифорок должно быть в вашем манускрипте? ");
//int size = int.Parse(Console.ReadLine());
//int[] arr = new int[size];
//arr = FillingArr(arr);
//Print(arr);


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//    y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
//https://ru.onlinemschool.com/math/assistance/cartesian_coordinate/lines_intersection/


//double[] Math(int b1, int c1, int b2, int c2)
//{
//    double[] a;
//    double temp1 = b1 - b2; 
//    double temp2 = c1 - c2;

//    if (temp2 < 0)
//    { 
//        temp2 *= (-1); 
//    }

//    double x1 = temp2 / temp1;
//    double x2 = b2 * x1 + c2;
//    a = new double[]{x1, x2};

//    return a;
//}

//Console.WriteLine("Введите данные первого уравнения y = bx + c");
//Console.Write("b = ");
//int b1 = int.Parse(Console.ReadLine());
//Console.Write("c = ");
//int c1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите данные второго уравнения y = bx + c");
//Console.Write("b = ");
//int b2 = int.Parse(Console.ReadLine());
//Console.Write("c = ");
//int c2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"{string.Join(", ", Math(b1, c1, b2, c2))}");


//Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
//(Следующее число складывается из двух предыдущих)
//Если N = 5-> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8


int[] Recursion(int a)
{
    int[] answer = new int[a];
    for (int i = 0; i < a; ++i)
    {
        if (i < 2)
        {
            answer[i] = i;
        }
        else
        {
            answer[i] = answer[i - 1] + answer[i - 2];
        }
    }
    return answer;
}


Console.Write("Введите число, до которого вывести ряд Фибоначчи: ");
int value = int.Parse(Console.ReadLine());
Console.Write($"Посмотрим {string.Join(", ", Recursion(value))}");
