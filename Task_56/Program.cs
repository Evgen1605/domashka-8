/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();

int minSumLine = 0;// создал переменную с минимальной суммой в строке с индесом(0)
int sumLine = SumLineElements(array, 0);// в переменную складываем действие функции подсчёта элементов в строках

for (int i = 0; i < array.GetLength(0); i++)// циклом проходим по элементам массива
{
  int tempSumLine = SumLineElements(array, i);// сщздал временную переменную в которую складываем функцию 
  if (sumLine > tempSumLine)// проверяем если строка с суммой элементов больше суммы следующей строки
  {
    sumLine = tempSumLine;// то в эту переменную записываем наименьшую сумму
    minSumLine = i;// к наименьшей с суммой строке присваиваем её индекс
  }
}

WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой  элементов ");


int[,] GetArray(int m, int n, int minValue, int maxValue)// функция для заполнения 2-мерного массива рандомными элементами
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);// обращаемся к каждому элементу массива и складывем рандомные числа
    }
  }
  return result;
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

int SumLineElements(int[,] array, int i)// функция подсчёта суммы элементов в строках массива
{
  int sumLine = array[i, 0];// в переменную складываем 2-мерный массив с элементами от i до 0
  for (int j = 0; j < array.GetLength(1); j++)// циклом проходим по строкам массива 
  {
    sumLine += array[i, j];// в переменуую записываем сумму элементов строки после каждой итерации
  }
  return sumLine;// возвращаем полученный результат
}

