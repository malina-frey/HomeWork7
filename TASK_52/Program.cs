/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetRandomArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(0, deviation + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arrayToPrint)
{

    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMeanСolumn(int[,] arrayAverageColumn, int rowNumber, int colNumber)
{
    for (int j = 0; j < colNumber; j++)
    {
        double average = 0;
        double sum = 0;
        for (int i = 0; i < rowNumber; i++)
        {
            sum = sum + arrayAverageColumn[i, j];
        }
        average = sum / rowNumber;
        Console.Write(Math.Round(average, 2) + "\t");
    }

}

Console.WriteLine("Укажите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество колонок в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomArray(rows, column, 10);

Console.WriteLine("--------------------------");
PrintArray(randomArray);
Console.WriteLine("--------------------------");
PrintArithmeticMeanСolumn(randomArray, rows, column);