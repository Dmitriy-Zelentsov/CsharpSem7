// ЗАдайте двумерный массив размера m*n,
//каждый элемент в массиве находится по формуле Amn=m+n
//Выведите полученный масив на экран

int[,] CreateMatrix (int rowCount, int columnCount)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = row + column;
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
int [,] array = CreateMatrix(5, 3);
PrintMatrix(array);
