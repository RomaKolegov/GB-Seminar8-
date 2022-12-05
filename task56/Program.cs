/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int arraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    return numbersFromUser;
}

int[,] generateArray(int Row, int Col, int range)
{
    int[,] array = new int[Row, Col];
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Col; j++)
        {
            array[i,j] = new Random().Next(-range, range + 1);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] ArrayOfTheSumOfLine(int[,] array)
{
    int[] arraySumOfLine = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int SumOfLine = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumOfLine = SumOfLine + array[i,j];
        }
        arraySumOfLine[i] = SumOfLine;
    }
    return arraySumOfLine;
}

void SmallestOfTheSumOfLine(int[] array)
{
    int minSum = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
        minSum = array[i];
        minIndex = i + 1;
        }
    }
    Console.WriteLine($"Наименьшая сумма чисел в строке № {minIndex} и равна {minSum}");
}

int Row = arraySizeFromUser("Введите количество строк массива");
int Col = arraySizeFromUser("Введите количество столбцов массива");
Console.WriteLine("Сгенерированный массив");
int[,] array = generateArray(Row, Col, 10);
printArray(array);
Console.WriteLine();
int[] arraySumOfLine = ArrayOfTheSumOfLine(array);
SmallestOfTheSumOfLine(arraySumOfLine);
