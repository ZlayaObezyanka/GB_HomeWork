//// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//// Например, задан массив:
//// 1 4 7 2
//// 5 9 2 3
//// 8 4 2 4
//// В итоге получается вот такой массив:
//// 7 4 2 1
//// 9 5 3 2
//// 8 4 4 2

//Console.WriteLine("Введите количество строк");
//int row = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов");
//int col = int.Parse(Console.ReadLine());


//int[, ] arr = new int[row, col];
//arr = getArr(arr);
//print(arr);
//arr = sortArr(arr);
//print(arr);

//int[, ] getArr(int[, ] arr)
//{
//    Random rnd = new Random();
//    for (int i = 0; i < arr.GetLength(0); ++i)
//    {
//        for (int j = 0; j < arr.GetLength(1); ++j)
//        {
//            arr[i, j] = rnd.Next(10);
//        }
//    }
//return arr;
//}

//void print(int[, ] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Console.Write($"{arr[i, j]}, ");
//        }
//        Console.WriteLine();
//    }
//}

//int[, ] sortArr(int[, ] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 1; j < arr.GetLength(1); ++j)
//        {
//            int temp = j ;
//            int x = arr[i, j];
//            while (temp > 0 && arr[i, temp - 1] < x)
//            {
//                arr[i, temp] = arr[i, temp - 1];
//                --temp;
//            }
//            arr[i, temp] = x;
//        }
//    }
//    return arr;
//}




////Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
////1, 2, 3
////4, 6, 1
////2, 1, 6

////1 встречается 3 раза
////2 встречается 2 раз
////3 встречается 1 раз
////4 встречается 1 раз
////6 встречается 2 раза


//using System.Diagnostics.Metrics;
//using System.Reflection;

//Random random = new Random();
//int size = random.Next(2, 5);
//int[,] arr = new int[size, size];
//arr = getArr(arr);
//print(arr);
//sortArr(arr);

//int[,] getArr(int[,] arr)
//{
//    Random rnd = new Random();
//    for (int i = 0; i < arr.GetLength(0); ++i)
//    {
//        for (int j = 0; j < arr.GetLength(1); ++j)
//        {
//            arr[i, j] = rnd.Next(10);
//        }
//    }
//    return arr;
//}

//void print(int[,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Console.Write($"{arr[i, j]}, ");
//        }
//        Console.WriteLine();
//    }
//}

//void sortArr(int[,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 1; j < arr.GetLength(1); ++j)
//        {
//            int temp = j;
//            int x = arr[i, j];
//            while (temp > 0 && arr[i, temp - 1] < x)
//            {
//                arr[i, temp] = arr[i, temp - 1];
//                --temp;
//            }
//            arr[i, temp] = x;
//        }
//    }
//    element_counter(arr);
//}

////делает дубликаты. Нужно сделать проверку, на проверенные числа, но голова не работает. Надеюсь потом допилю
//void element_counter(int[, ] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        int counter = 0;
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            for (int t = 0; t < arr.GetLength(0); t++)
//            {
//                for (int k = 0; k < arr.GetLength(1); k++)
//                {
//                    if (arr[i, j] == arr[t, k])
//                    {
//                        ++counter;
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//            }
//            Console.WriteLine($"Число {arr[i, j]} встречается {counter} раз");
//            counter = 0;
//        }
//    }
//} 



////Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
////Например, даны 2 матрицы:
////2 4 | 3 4
////3 2 | 3 3
////Результирующая матрица будет:
////18 20
////15 18


//Random random = new Random();
//int size = random.Next(2, 2);
//int[,] arr_1 = new int[size, size];
//int[,] arr_2 = new int[size, size];
//arr_1 = getArr(arr_1);
//arr_2 = getArr(arr_2);
//print(arr_1);
//Console.WriteLine();
//print(arr_2);
//matrix_multip(arr_1, arr_2);

//int[,] getArr(int[,] arr)
//{
//    Random rnd = new Random();
//    for (int i = 0; i < arr.GetLength(0); ++i)
//    {
//        for (int j = 0; j < arr.GetLength(1); ++j)
//        {
//            arr[i, j] = rnd.Next(10);
//        }
//    }
//    return arr;
//}

//void print(int[,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Console.Write($"{arr[i, j]}, ");
//        }
//        Console.WriteLine();
//    }
//}

//void matrix_multip(int[,] arr_1, int[,] arr_2)
//{
//    int[,] temp = new int[arr_2.GetLength(0), arr_2.GetLength(1)];
//    for (int i = 0; i < arr_1.GetLength(0); ++i)
//    {
//        for (int j = 0; j < arr_2.GetLength(1); j++)
//        {
//            for (int k = 0; k < arr_1.GetLength(1); k++)
//            {
//                temp[i, j] += arr_1[i, k] * arr_2[k, j];
//            }
//        }
//    }

//    print(temp);
//}


// Нужно доделать. я работаю над этой и следующей задачей. Просто чтоб не было просрочки скидываю в таком виде
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random random = new Random();
int size = random.Next(2, 5);
int[,,] arr = new int[size, size, size];
arr = getArr(arr);
print(arr);

int[,,] getArr(int[,,] arr)
{
	int temp = 0;
	int[] tempArr = new int[size*size*size];
	for (int i = 0, j = 1; i < tempArr.Length; ++j, i++)
	{
        temp = random.Next(2, 90);
        for (int z = 0; z < j; z++)
		{
			if (tempArr[z] == temp)
			{
				temp = random.Next(2, 50);
				z = 0;
			}
		}
        tempArr[i] = temp;
    }

    temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); ++temp, k++)
			{
				arr[i, j, k] = tempArr[temp];
			}
		}
	}

    return arr;
}

void print(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})");
			}
			Console.WriteLine();
		}
	}


}


