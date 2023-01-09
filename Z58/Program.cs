// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

void ProductMatrix(int[,] firstMatrix, int [,] secondMatrix, int [,] resMatrix)
{
    for(int i=0;i< resMatrix.GetLength(0); i++)
    {

         for(int j=0; j< resMatrix.GetLength(1); j++)
         {
            int res = 0;
            for(int k=0; k< firstMatrix.GetLength(1); k++)
            {
                res += firstMatrix[i,k] * secondMatrix[k,j];
            }
            resMatrix[i,j] = res;
         }
         Console.WriteLine();
    }
   
}

Console.Write("Введите количество строк матрицы 1: ");
int rowsM1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы 1: ");
int columsM1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк матрицы 2 должно совпадать с количеством столбцов матрицы 1: ");

Console.Write("Введите количество строк матрицы 2: ");
int rowsM2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы 2: ");
int columsM2 = int.Parse(Console.ReadLine());

if(columsM1 == rowsM2)
{
    
    int[,] matrix1 = GetArray(rowsM1,columsM1,0,10);
    PrintArray(matrix1);
    Console.WriteLine();
    int[,] matrix2= GetArray(rowsM2,columsM2,0,10);
    PrintArray(matrix2);
    Console.WriteLine();
    int[,] resultMatrix = new int[rowsM1,columsM2];
    
    ProductMatrix(matrix1,matrix2,resultMatrix);
    PrintArray(resultMatrix);
}
else
{
    Console.WriteLine("Некорректные данные");
}



