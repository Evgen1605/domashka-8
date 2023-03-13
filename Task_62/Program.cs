// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      // Добавление ведущего нуля
      if (array[i, j] < 10) Write($"0{array[i, j]} ");
      else Write($"{array[i, j]} ");
    }
    WriteLine();
  }
  WriteLine();
}

// Метод заполняющий квадратные двумерные массивы числами по спирали
int[,] SpiralArray(int n)
{
  // Создаем пустой массив
  int[,] array = new int[n, n];
  // Координаты массива: горизонталь, вертикаль
  int i = 0, j = 0;
  // В цикле создаем числа для из записи в массив
  for (int count = 1; count <= n * n; count++)
  {
    array[i, j] = count;
    // вычисляем координаты для записи следующего значения
    // сверху слева направо
    if (i <= j + 1 && i + j < n - 1) j += 1;
    // справа сверху вниз
    else if (i < j) i += 1;
    // снизу справа налево
    else if (i + j >= n) j -= 1;
    // слева снизу вверх
    else if (i >= j) i -= 1;
  }
  return array;
}

// Печать квадратного массива 4х4 заполненного по спирали
PrintArray(SpiralArray(4));