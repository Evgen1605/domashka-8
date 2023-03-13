// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(0,0,1) 41(0,1,1)
//27(1,0,0) 90(1,0,1)
//26(1,1,0) 55(1,1,1)
using System;
using static System.Console;


Clear();

WriteLine("Задайте размер массива");
Write("Введите x: ");
int x = int.Parse(ReadLine()!);
Write("Введите y: ");
int y = int.Parse(ReadLine()!);
Write("Введите z: ");
int z = int.Parse(ReadLine()!); 

int countNums = 89;

if (x * y * z > countNums)
{
  Write("Массив слишком большой");
  return;
}

int[,,] resultNums = Create3DMassive(x, y, z);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
  for (int j = 0; j < resultNums.GetLength(1); j++)
  {
    for (int k = 0; k < resultNums.GetLength(2); k++)
    {
      WriteLine($"{resultNums[i, j, k]} - ({i},{j},{k})");
    }
    WriteLine();
  }
  WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
  int[,,] array = new int[size1, size2, size3];
  int[] values = new int[countNums];
  int num
   = 10;
  for (int i = 0; i < values.Length; i++)
    values[i] = num
    ++;

  for (int i = 0; i < values.Length; i++)
  {
    int randomInd = new Random().Next(0, values.Length);
    int temp = values[i];
    values[i] = values[randomInd];
    values[randomInd] = temp;
  }

  int valueIndex = 0;

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = values[valueIndex++];
      }
    }
  }
  return array;
}
