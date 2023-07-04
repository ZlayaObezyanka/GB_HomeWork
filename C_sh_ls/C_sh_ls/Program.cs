// //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.



// //int value = new Random().Next(100, 1000);

// //int fValue = value / 100;
// //int sValue = value % 10;

// //int an = fValue * 10 + sValue;
// //Console.WriteLine($"{value} {an}");



// //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// //Если второе число не кратно числу первому, то программа выводит остаток от деления.

// //34, 5 -> не кратно, остаток 4
// //16, 4  -> кратно

// int fValue;
// int sValue;
// int an;

// Console.WriteLine("Введите первое число: ");
// fValue = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// sValue = int.Parse(Console.ReadLine());



// if (fValue % sValue == 0)
// {
//     Console.WriteLine($"{fValue} и {sValue} кратны");
// }
// else
// {
//     an = fValue % sValue;
//     Console.WriteLine($"{fValue} и {sValue} не кратны. Остаток {an}");
// }


// //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// //14  ->  нет
// //46  ->  нет
// //161 ->  да


// //int fValue;

// //Console.WriteLine("Введите ваше число");
// //fValue = int.Parse(Console.ReadLine());

// //if (fValue % 7 == 0 && fValue % 23 == 0)
// //{
// //    Console.WriteLine($"{fValue} кратно одновременно 7 и 23");
// //}
// //else
// //    Console.WriteLine($"{fValue} не кратно одновременно 7 и 23");




// //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


// //int fValue = 0;
// //int sValue = 0;


// //Console.WriteLine("Введите первое число");
// //fValue = int.Parse(Console.ReadLine());

// //Console.WriteLine("Введите второе число");
// //sValue = int.Parse(Console.ReadLine());

// //if (fValue / sValue == sValue || sValue / fValue == fValue)
// //    Console.WriteLine($"Является одно sqr другого");
// //else Console.WriteLine("ну всё, приехали");



// //using System.Security.Cryptography;

// //int a = 5;
// //int i = 0;
// //int x = 564;

// //while ((99 < x) && (x < 1000))
// //{
// //    Console.WriteLine("отработал");
// //    x = 0;
// //}

// void quantity(int x)
// {
//     int value_in_function = 1;
//     int i = 2;
//     while(i <= x)
//     {
//         value_in_function *= i;
//         ++i;
//     } 
//     Console.WriteLine(value_in_function);
// }

// Console.Write("Введите число: ");
// int value = int.Parse(Console.ReadLine());

// quantity(value);



//**Задача 40:**Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.

//<aside>
//❗ **Теорема о неравенстве треугольника:**каждая сторона треугольника меньше суммы двух других сторон.

//</aside>


//void triangle(int a, int b, int c)
//{ 
//    if (a + b - c < a)
//    {
//        Console.WriteLine("Всё верно");
//    }
//}

//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//triangle(a, b, c);





//**Задача 42:**Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10


void bin(int value)
{
    Console.WriteLine($"{Convert.ToString(value, 2)}");
}

int b = 12;

bin(b);


int[] fillingA_FingArr(int[] arr, int size_min, int size_max)
{ // Заполнение массива, который CERF очень достал
    Random temp = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = temp.Next(size_min, size_max);
    }

    return arr;
}