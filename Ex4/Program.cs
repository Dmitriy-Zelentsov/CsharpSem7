// Задача 51: Задайте двумерный массив. Найдите
//сумму элементов, находящихся на главной диагонали(с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


int[,] CreateMatrix (int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix (int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int FindSumm (int[,] arr)
{
    int summ = 0;
     for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            if (row == column)
            {
                summ += arr[row, column];
            }
        }
    }
    return summ;
}

int [,] array = CreateMatrix(3, 4, 1, 3);
PrintMatrix(array);
Console.WriteLine();
Console.WriteLine ($"Сумма ээлементов на главной диагонали = {FindSumm (array)}");
