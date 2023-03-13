//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
using static System.Console;

Clear();

Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(ReadLine()!);
Write("Введите число столбцов 1-й матрицы = строк 2-й матрицы: ");
int n = int.Parse(ReadLine()!);
Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(ReadLine()!);
WriteLine();

int[,] MartrixA = new int[m, n];
GetArray(MartrixA);
WriteLine("Первая матрица:");
PrintArray(MartrixA);
WriteLine();

int[,] MartrixB = new int[n, p];
GetArray(MartrixB);
WriteLine("Вторая матрица:");
PrintArray(MartrixB);
WriteLine();

int[,] MatrixC = new int[m, p];

MultiplyMatrix(MartrixA, MartrixB, MatrixC);
WriteLine("Произведение первой и второй матриц:");
PrintArray(MatrixC);


// функция умножения 2-х матриц
void MultiplyMatrix(int[,] MartrixA, int[,] MartrixB, int[,] MatrixC)
{
  for (int i = 0; i < MatrixC.GetLength(0); i++)
  {
    for (int j = 0; j < MatrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < MartrixA.GetLength(1); k++)
      {
        sum += MartrixA[i, k] * MartrixB[k, j];
      }
      MatrixC[i, j] = sum;
    }
  }
}

// функция для заполнения 2-мерного массива рандомными элементами
void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
}

void PrintArray(int[,] inArray)// функция вывода 2-мерного массива
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");// сначала записываем все элементы перврго массива, потом все элементы второго массива и т.д
    }
    WriteLine();//переносим на новую строчку
  }
}
