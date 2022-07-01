/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
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

void FindElementsArray(int[,] arrayToFind, int findNumber)
{
    int count = 1;
    for (int i = 0; i < arrayToFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFind.GetLength(1); j++)
        {

            if (count == findNumber)
            {
                Console.WriteLine(findNumber + " -> " + arrayToFind[i, j]);
            }
            count++;
        }
    }
}

Console.WriteLine("Укажите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество колонок в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер элемента в массиве: ");
int findElements = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomArray(rows, column, 10);
Console.WriteLine("--------------------------");
PrintArray(randomArray);
Console.WriteLine("--------------------------");
FindElementsArray(randomArray, findElements);

if (findElements > rows * column)
{
    Console.Write(findElements + " -> ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Такого элемента в массиве нет");
}
