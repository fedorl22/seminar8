// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSum(int[,] matr)
{
    int indexMinSum=0;
    int minSum = 9999999;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int[] sum= new int[matr.GetLength(0)];
        
        sum[i] = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += sum[i] + matr[i, j];
        }
        if(minSum>sum[i])
        {
            minSum=sum[i];
            indexMinSum=i;
        }
    }
   return indexMinSum; 
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
int m = MinSum(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов - {m+1}");

