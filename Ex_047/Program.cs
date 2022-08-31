﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    Random rand = new Random();
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(1,101)/100.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j =0; j < array.GetLength(1);j++)
        {
           Console.Write(array[i,j] + " | ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размер массива по вертикали: ");
int rangeVertical = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива по горизонтали: ");
int rangeHorizontally = Convert.ToInt32(Console.ReadLine());
double[,] myArray = new double[rangeHorizontally,rangeVertical];
FillArray(myArray);
PrintArray(myArray);