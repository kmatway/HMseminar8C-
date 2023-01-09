// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindSumEl(int[,] inArray, int i)
{
    int sum = inArray[i,0];
    for(int j=0; j < inArray.GetLength(1); j++)
    {
        sum += inArray[i,j];
    }
    return sum;
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows,colums,0,10);
PrintArray(array);
Console.WriteLine();

int sum = FindSumEl(array,0);
int minsum = FindSumEl(array,1);
int minSumLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if(sum > minsum)
    {
      sum = minsum;
      minSumLine = i;   
    }
}

Console.WriteLine($"{minSumLine+1} - строка с наименьшей суммой элементов {sum}");




