
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int value = 1;
// int ansver = 0;
// bool i = true;

// while(i){
// Console.Write("Введите 3х-значное число:");
// value = int.Parse(Console.ReadLine());
//     if(value > 99 && value < 1000)
//     {
//         ansver = (value / 10) % 10;
//         Console.WriteLine(ansver);
//         break;
//     }
//     else{
//         Console.WriteLine("Вы ввели не 3х-значное число. Го повторно.");
//     }

// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int value = 0;
// int temp = 0;
// int i = 0;
// Random rnd = new Random();

// value = rnd.Next(0, 100000);
// temp = value;

// while(true)
// {
//     if(temp > 0)
//     {
//         ++i;
//         temp /= 10;
//     }
//     else{ 
//         i -= 2;
//         break;
//     }
// }

// temp = value;

// if(i == 0)
// {
//     Console.WriteLine($"{value} -- не хватает разрядов");
// }
// else{
//     while(i >= 0)
//     {      
//         if(i == 1)
//         {   
//         value %= 10;
//         Console.WriteLine($"Число{temp}, {value}");
//         break;
//     }
//     value /= 10;
//     Console.WriteLine($"Число{temp}, {value}");
//     --i;
// }
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

uint day = 0; 

Console.Write("Введите день недели:");
day = uint.Parse(Console.ReadLine());
if(day > 7)
{
    Console.WriteLine("Ты шо, круглоглазый?!");
}
else
{
    if(day < 6)
    {
        Console.WriteLine($"{day} Культурно выпиваем, но аккуратно. у нас будни");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine($"{day} Господа, культурно выпиваем, ведь это ВЫХОДНЫЕ!");
    }
}