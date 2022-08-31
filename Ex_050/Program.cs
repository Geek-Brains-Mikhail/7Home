// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
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
int[,] myArray = new int[3,4];
FillArray(myArray);
Console.Write("Введите позицию элемента по вертикали: ");
int positionVertical = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по горизонтали: ");
int positionHorizontally = Convert.ToInt32(Console.ReadLine());
if ((positionVertical >= 0 && positionVertical < myArray.GetLength(0))
    && positionHorizontally >= 0 && positionHorizontally < myArray.GetLength(1))
{
    Console.WriteLine($"Элемент, по позициям ({positionVertical};{positionHorizontally}) - {myArray[positionVertical, positionHorizontally]}");
}
else
{
    Console.WriteLine($"Элемент, по позициям ({positionVertical};{positionHorizontally}) не существует");
}

