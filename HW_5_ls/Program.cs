// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

{
int sum = 0;

Random size = new Random();

int[] arr = new int [size.Next(5, 10)];
int[] arr_3task = new int[size.Next(9, 10)];

arr = fillingA_FingArr(arr); // первая домашка
sum = sum_not_even(arr); // Второе задание // я не знаю, почему я сделал через инт, понимая, что можно сделать через войд... 
print(arr);

Console.WriteLine("\n_______________________________________");
arr_3task = fillingA_FingArr(arr_3task);
sum = dif(arr_3task);
print(arr_3task);
}

void print(int[] arr) // Вывод массива, для визуального понимания, с чем мы работаем 
{
    Console.Write($"Чертов массив равен: {string.Join(", ", arr)}");
}

void printTasks(int quantity) // вывод значений
{
    Console.WriteLine($"Значение равно: {quantity}");
}

int Even(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i] % 2 == 0){
        ++temp;
        }
    }
return temp;
}

int[] fillingA_FingArr(int[] arr) // Заполнение массива, который CERF очень достал
{
    int temp_num = 0;
    Random temp = new Random();
    for(int i= 0; i < arr.Length; ++i)
    {
        arr[i] = temp.Next(99, 1000);
    }
    temp_num = Even(arr);
    printTasks(temp_num);

return arr;
}

int sum_not_even(int[] arr) // сумма на позициях %2 != 0 
{
    int temp = 0;

    for(int i = 0; i < arr.Length; ++i)
    {
        if(i % 2 != 0)
        {
            temp += arr[i];
        }
    }
    printTasks(temp);
return temp;
}

int dif(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int temp = 0;
    for(int i = 0; i < arr.Length; ++i)
    {
        max = max < arr[i] ? arr[i] : max;
        min = min > arr[i] ? arr[i] : min;
    }

    temp = max - min;
    printTasks(temp);

return temp;
}



