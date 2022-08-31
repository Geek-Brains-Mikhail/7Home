// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
double ArithmeticMean(int[,] array, int count)
{
    double arithmeticnumber = 0;
    for (int i = 0; i < array.GetLength(0);i++)
    {
        arithmeticnumber += array[i,count];
    }
    return arithmeticnumber/array.GetLength(0);
}
int[,] myArray = new int[3, 4];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
int count = 0;
double[] arrayArithmeric = new double[myArray.GetLength(1)];
while (count < arrayArithmeric.Length)
{
    arrayArithmeric[count] = Math.Round(ArithmeticMean(myArray, count),1);
    count++;
}
Console.WriteLine("Среднее арифметическое каждого столба: " + string.Join("|",arrayArithmeric));
