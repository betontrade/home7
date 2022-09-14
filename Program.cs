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

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


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


// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// строка 1   столбец 7 ->  числа с таким индексом в массиве нет. ("Индексы считаем от ноля")




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// Одномерный массив вещественных чисел double

// Console.Write( Math.Round(2.34443, 2));
                           //      /\ Знаки после запятой  
