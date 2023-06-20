// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int degree(int value_a, int degree_of_number)
// {
//     int fing_degree_of_value = value_a;
//     for (int i = 1; i < degree_of_number; ++i)
//     {
//         fing_degree_of_value *= value_a;
//     }
//     return fing_degree_of_value;
// }

// int ansver = 0;
// int f_Value = 0;
// int s_Value = 0;
// Console.Write("Введите число, которое не является буквой: ");
// f_Value = int.Parse(Console.ReadLine());

// Console.Write("Введите степень, которая не является буквой: ");
// s_Value = int.Parse(Console.ReadLine());

// ansver = degree(f_Value, s_Value);
// Console.WriteLine(ansver);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int sum_of_digits(int num)
// {
//     int ansver = 0;
//     int temp = num;
//     int size = 0;
//     while (temp > 0)
//     {
//         temp /= 10;
//         ++size;
//     }
//     for (int i = 0; i < size; ++i)
//     {
//         ansver += (num % 10);
//         num /= 10;
//     }
//     return ansver;
// }

// int f_Value = 0;

// Console.Write("Введите число своих жен: ");
// f_Value = int.Parse(Console.ReadLine());

// Console.WriteLine($"{sum_of_digits(f_Value)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*лучше подойдет функция void для вывода. Назвал бы void Print*/ 
void Print(int[] arr)
{
    Console.Write("[{0}]", string.Join(", ", arr ));

}
int I_Am_Function(int[] I_am_Num)
{
    Random rnd = new Random();
    for (int i = 0; i < I_am_Num.Length; ++i)
    {
        I_am_Num[i] = rnd.Next(1, 50);
    }
    Print(I_am_Num);
    return 0;
}

    Console.Write("курлык");
    int[] arr = new int[8];
    I_Am_Function(arr);