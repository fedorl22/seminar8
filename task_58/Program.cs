// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10) //задали матрицу.
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++) //GetLength(0) для строк 0, метод.
    {
        for (int j = 0; j < matr.GetLength(1); j++) //GetLength(0) для столбцов 1.
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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine(); 
    }
}

Console.Clear();
int rows = GetNumber("Введите число строк");
int columns = GetNumber("Введите число столбцов");
int[,] matr1 = GetMatrix(rows, columns);
int[,] matr2 = GetMatrix(rows, columns);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
int[,] mult = new int[rows, columns];
for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        mult[i,j]=matr1[i,j]*matr2[i,j];
      }
    }
PrintMatrix(mult);
