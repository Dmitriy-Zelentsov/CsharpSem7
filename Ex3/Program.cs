// Задайте двумерный массив.Найдите элементы,у которых
//обба индекса четные, и замените эти элементы на их квадраты

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

void FintElement (int[,] arrdif)
{
     for (int row = 0; row < arrdif.GetLength(0); row++)
    {
        for (int column = 0; column < arrdif.GetLength(1); column++)
        {
            if (row % 2 != 0 && column % 2 != 0)
            {
                arrdif [row,column]*= arrdif[row,column];
            }
            Console.Write($"{arrdif[row, column]}\t");
        }
    }
}


int [,] array = CreateMatrix(5, 3, 1, 3);
PrintMatrix(array);
Console.WriteLine();
FintElement (array);