﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m,int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0;i< inArray.GetLength(0); i++)
    {

         for(int j=0; j< inArray.GetLength(1); j++)
         {
            Console.Write($" {inArray[i,j]} ");
         }
         Console.WriteLine();
    }
   
}

void DescendingNumbers(int[,] inArray)
{
     for(int i=0;i< inArray.GetLength(0); i++)
    {

        for(int j=0; j< inArray.GetLength(1); j++)
        {
            for(int k=0; k < inArray.GetLength(1)-1; k++)
            {
                if(inArray[i,k]< inArray[i,k+1])
                {
                    int buf = inArray[i,k+1];
                    inArray[i,k+1]=inArray[i,k];
                    inArray[i,k] = buf;
                }
            }
        }
    }

}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows,colums,0,10);
PrintArray(array);
Console.WriteLine();
DescendingNumbers(array);
PrintArray(array);
