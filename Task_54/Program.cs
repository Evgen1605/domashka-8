/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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
WriteLine($"Отсортированный массив: ");
OrderArrayLines(array);
PrintArray(array);

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

void OrderArrayLines(int[,] array)// функция упорядочивает строки массива, а вход принимает 2-мерный массив
{
  for (int i = 0; i < array.GetLength(0); i++)// запускаем цикл который будет перебирать массивы(строки)
  {
    for (int j = 0; j < array.GetLength(1); j++)// цикл перебирает (столбцы) 
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)// циклом перебираем элементы
      {
        if (array[i, k] < array[i, k + 1])// проверяем если в строке(i) элемент(k) меньше чем следующий то
        {
          int temp = array[i, k + 1];// записываем больший элемент
          array[i, k + 1] = array[i, k];// меняем местами больший с меньшим
          array[i, k] = temp;// результат записываем в переменную
        }
      }
    }
  }
}