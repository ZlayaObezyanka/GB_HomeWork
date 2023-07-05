// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//i = 1, j = 2-> 2
//i = 4, j = 2->такого элемента не существует

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//* Сумма всех цифр / их количество(это количество ваших строк)



namespace program {

    class Print
    {
        public void PrintArr(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
        public void PrintArr(double[,] arr, int column, int row)
        {
            if ((row < 0 || row > arr.GetLength(0)) || (column < 0 || column > arr.GetLength(1)))
            {
                Console.WriteLine("Не туда");
                return;
            }
            else
            {
                Console.Write($"{arr[row - 1, column - 1]}");
            }
            Console.WriteLine();
        }
        public void PrintArr(int[,] arr, int average)
        {
            double[] valueMean = new double[arr.GetLength(1)];
            int temp = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    temp += arr[j, i];
                }
                valueMean[i] = (double)temp / (double)average;
            }
            Console.WriteLine(string.Join(", |", valueMean));
            Console.WriteLine();
        }
        public void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class prg
    {
        double[,] GetArr(int x, int y)
        {
            Random rnd = new Random();
            double[,] arr = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //arr[i,j] = Math.Round(rnd.NextDouble() * 100 , 2) ;
                    arr[i, j] = Math.Round(rnd.Next(-10000, 10000) * 0.01, 2);
                }
            }
            Print printarr = new Print();
            printarr.PrintArr(arr);
            return arr;
        }
        int[,] GetArr(int x, int y, int average)
        {
            Random random = new Random();
            Print printarr = new Print();

            int[,] arr = new int[x, y];
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    arr[i, j] = random.Next(25);
                }
            }
            printarr.PrintArr(arr);
            printarr.PrintArr(arr, average);
            return arr;
        }

        static void Main()
        {
            prg error_bypass = new prg();
            Print printOut = new Print();
            int column = 0;
            int row = 0;
            double[,] arr;

            Console.Write($"Введите колличество столбцов: ");
            column = int.Parse(Console.ReadLine());

            Console.Write($"Введите колличество строк: ");
            row = int.Parse(Console.ReadLine());

            arr = error_bypass.GetArr(row, column);

            Console.Write($"Введите позицию в столбце: ");
            int userColumn = int.Parse(Console.ReadLine());

            Console.Write($"Введите позицию в строке: ");
            int userRow = int.Parse(Console.ReadLine());

            printOut.PrintArr(arr, userRow, userColumn);

            error_bypass.GetArr(row, column, row);
        }
    }
}




