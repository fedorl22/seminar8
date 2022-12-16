// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7

// 2 3 5 9

// 2 4 4 8
//void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1 ; i++)
//     {
//            int minPosition = i;

//     for (int j = i + 1; j < array.Length; j++)
//     {
//         if (array[j] < array[minPosition]) minPosition = j;
//     }
//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;
//     }
// }

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10) //задали матрицу.
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i, j] = rand.Next(leftRange, rightRange);

        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) для строк 0, метод.
    {
        for (int j = 0; j < matr.GetLength(1) - 1 ; j++)
    {
           int minPosition = j;

    for (int y = j + 1; y < matr.GetLength(1); y++)
    {
        if (matr[i,y] < matr[i,minPosition]) minPosition = y;
    }
    int temporary = matr[i,j];
    matr[i,j] = matr[i,minPosition];
    matr[i,minPosition] = temporary;
    }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) для строк 0, метод.
    {
        for (int j = 0; j < matr.GetLength(1); j++) //GetLength(0) для столбцов 1, метод.
        {
            Console.Write(matr[i, j] + "");
        }
        Console.WriteLine(); //чтобы печаталось новая строка с новой строки.
    }
}




Console.Clear();
int rows = GetNumber("Введите число строк");
int colums = GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, colums);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);