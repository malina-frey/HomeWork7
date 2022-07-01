/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] FillArray(int rows, int column, int loweBorder, int upperBorder)
{
    double[,] result = new double[rows, column];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().NextDouble() * upperBorder + loweBorder;
        }
    }
    return result;
}

void PrintArray(double[,] arrayToPrint)
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("----------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j], 2));
            Console.Write("     ");
        }

    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------");
}

Console.WriteLine("Укажите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество колонок в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());


double[,] arrayToPrint = FillArray(rows, column, -10, 20);
PrintArray(arrayToPrint);
