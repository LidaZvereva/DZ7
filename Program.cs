// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите количество строк  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[m, n];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите строку: ");
// int line = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int column = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 4; 
// int m = 5; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (line < 0 | line > arr.GetLength(0) - 1 | column < 0 | column > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует  ");
// }
//     else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[line, column]);
// }
// Console.ReadLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Random random = new Random();
// int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(1, 10);
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("---------------------------");
// Console.WriteLine(arr.GetLength(0));
// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum += arr[i, j];
//     }
//     Console.Write($"{ sum / arr.GetLength(0)} ");
// }
// Console.ReadLine();
