/*
void Zamena (int [,] mass)
{
    for (int i = 2; i < mass.GetLength(0); i= i +2)
    {
        for ( int j = 2; j < mass.GetLength(1) ; j = j +2)
        {
            mass[i, j] = (i + j) * (i + j);
        }
    }
}
*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

 /* Решение внутри 

double [,] CreateArrayMy (int m, int n)
{
    double [,] array = new double [m, n];
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            array[i, j] =new Random().Next(-10, 10) +  new Random().NextDouble() ;
        }
    }

    return array;
}

void ShowArrayMy (double [,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            if (array[i, j] > 0)
            {
                  Console.Write( " " + (Math.Round (array[i, j], 2)) + " " );
            }
            else
            {
                Console.Write((Math.Round (array[i, j], 2)) + " " );
            }
        }
        Console.WriteLine();
    }

}

Console.Write("Пожалуйста введите количество строк: ");
int rows = Convert.ToInt32( Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] arrayEnd = CreateArrayMy( rows, columns);

ShowArrayMy(arrayEnd);

*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

 /* Решение внутри

int [,] CreateArrayMy (int m, int n)
{
    int [,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            array[i, j] =new Random().Next(-9, 10) ;
        }
    }

    return array;
}


void ShowArrayMy (int [,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            if (array[i, j] >= 0)
            {
                  Console.Write( " " +  array[i, j] + " " );
            }
            else
            {
                Console.Write(array[i, j] + " " );
            }
        }
        Console.WriteLine();
    }

}

void Seash (int [,] array, int seashRow, int seashColumn)
{
    if (seashRow <= array.GetLength(0) |  seashColumn <= array.GetLength(1))
    {
        Console.WriteLine("Число с индексами [" + seashRow +", "+  seashColumn+ "] равняется " + array [(seashRow-1), (seashColumn-1)] );
    }
    else
    {
         Console.WriteLine("Числа с индексами [" + seashRow +", "+  seashColumn+ "] в массиве нет");
    }
}

Console.Write("Пожалуйста введите количество строк: ");
int rows = Convert.ToInt32( Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arrayEnd = CreateArrayMy( rows, columns);

ShowArrayMy(arrayEnd);

Console.Write("Пожалуйста введите строку где находится число (отсчет начинается с 1): ");
int rowSeash = Convert.ToInt32(Console.ReadLine());


Console.Write("Пожалуйста введите столбец где находится число (отсчет начинается с 1): ");
int columnSeash = Convert.ToInt32(Console.ReadLine());

Seash(arrayEnd, rowSeash, columnSeash);

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/* Решение внутри

int [,] CreateArrayMy (int m, int n)
{
    int [,] array = new int [m, n];
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            array[i, j] =new Random().Next(1, 10) ;
        }
    }
    return array;
}

double [] AverageColumns (int [,] array)
{
    double [] averageArray = new double [array.GetLength(1)];

    double count = 0;
    double memory = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int  i =0  ; i < array.GetLength(0); i++)
        {
            count =   count +  array[i, j];
            memory = i;
        }
        double roundValue = count / (memory+1);
        averageArray[j] = Math.Round (roundValue, 2);
        count =0;
        memory = 0;
    }
    return averageArray;
}

void ShowArrayMy (int [,] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j ++)
        {
            if (array[i, j] >= 0)
            {
                  Console.Write( " " +  array[i, j] + " " );
            }
            else
            {
                Console.Write(array[i, j] + " " );
            }
        }
        Console.WriteLine();
    }

}

void ShowArrayMyDouble (double [] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
       
        Console.Write( "  " + array[i] );
       
    }
    Console.Write(". ");

}

Console.Write("Пожалуйста введите количество строк: ");
int rows = Convert.ToInt32( Console.ReadLine());

Console.Write("Пожалуйста введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] arrayEnd = CreateArrayMy( rows, columns);

Console.WriteLine("Программа сгенерировала массив: ");

ShowArrayMy(arrayEnd);

double [] arrayMean = AverageColumns(arrayEnd);

Console.Write("Среднее арифметическое каждого столбца: ");

ShowArrayMyDouble(arrayMean);

Console.WriteLine();

*/