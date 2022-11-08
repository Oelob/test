

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

// int Exponentiation (int arg1, int arg2)
// {
//     int result = 1;
//     for (int i = 0; i < arg2; i++)
//     {
//        result = result * arg1;
//     }
//     return result;
// }    
// Console.WriteLine("Введите число A: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"Результатом возведения числа {A} в степень {B} является {Exponentiation (A, B)}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int SumFigures (int number)
// {
//     int result = 0;
//     int x = 0;
//     for (int i = 0; number > 0; i++)
//     {
//        x = number%10;
//        number /=10;
//        result += x; 
//     }
//     return result;
// }
// Console.WriteLine("Введите число:");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {a} равняется {SumFigures(a)}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

// int[] Mas(int number)
// {
//     int[] result = new int[number];
//     for (int i = 0; i < number; i++)
//     {
//         result[i] = new Random().Next(100);
//     }
//     return result;
// }
// Console.WriteLine("Введите размер массива:");
// int size = int.Parse(Console.ReadLine());
// Console.WriteLine($"[ {String.Join(", ", Mas(size))} ]");