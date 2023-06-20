// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// int[] arr = new int[5];
// int ansver = 0;

// for(int i = 0; i < 5; ++i)
// {
//     Console.Write($"Введите {i+1} число: ");
//     arr[i] = int.Parse(Console.ReadLine());
//     ansver = (ansver * 10) + arr[i]; 
// }

// if(arr[0] == arr[4] && arr[1] == arr[3])
// {
//     Console.WriteLine($"{ansver} является палиндромом" );
// }
// else 
// {
//     Console.WriteLine("Из за этих гадов мы безработы сидим!11!!!1!(с)");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


//int[] first_point = new int[3];
//int[] second_point = new int[3];
//double ansver = 0; 

//for(int i = 0; i < 3; ++i)
//{
//    Console.Write($"Введите {i+1} координату: ");
//    first_point[i] = int.Parse(Console.ReadLine());
//}

//for(int i = 0; i < 3; ++i)
//{
//    Console.Write($"Введите {i+1} координату второй точки: ");
//    second_point[i] = int.Parse(Console.ReadLine());
//}



//ansver = Math.Sqrt(Math.Pow(second_point[0] - first_point[0], 2) +
//    Math.Pow(second_point[1] - first_point[1], 2) + Math.Pow(second_point[2] - first_point[2], 2));
//Console.WriteLine(ansver); 




//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите интервал кубов: ");
// uint index_cube = uint.Parse(Console.ReadLine());

// for (int i = 1; i <= index_cube; ++i)
// {
//     Console.WriteLine($"Куб числа {i} равен {Math.BigMul(i, i) * i}. Помни это сталкер!");
// }


int a = 2000;

if ((a / 10 > 0) && (a / 100 == 0))
{
    Console.WriteLine("Привет");
}
else 
    Console.WriteLine("Привет-пока");