// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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
            Console.Write(matr[i, j] + " ");
    Console.WriteLine();        
    }

}

Console.Clear();
int a00 = GetNumber("Введите первый элемент");
int[,] spiralMatr = new int[4, 4];
int temp = a00;
int i = 0;
int j = 0;
while (temp < 4 * 4 + a00)
{
    spiralMatr[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < 3)
        j++;
    else if (i < j && i + j >= 3)
        i++;
    else if (i >= j && i + j > 3)
        j--;
    else
        i--;
}

PrintMatrix(spiralMatr);



