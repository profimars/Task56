// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
//https://github.com/profimars/Task56
void CreateArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 10);
        }
}

void PrintArray(int[,] A)
{
    Console.WriteLine();
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}   ");
        Console.WriteLine();
    }
}

void SumLines(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int[] AA = new int[m];
    int kk = 0;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum = sum + A[i, j];
        }
        AA[i] = sum;
    }
    Console.WriteLine();
    int min = AA[0];
    for (int k = 0; k < m; k++)
    {
        Console.Write($"{AA[k],3}   ");
        if (AA[k] < min)
        {
            min = AA[k];
            kk = k;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строки с наименьшей суммой элементов: {(kk + 1)} строка");
}

Console.WriteLine("Введите количество строк матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
// int m = 5;
// int n = 4;
int[,] A = new int[m, n];
CreateArray(A);
PrintArray(A);
SumLines(A);
