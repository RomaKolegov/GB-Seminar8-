/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int arraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    return numbersFromUser;
}

int[,] generateFirstArray(int FirstRow, int FirstCol, int FirstRange)
{
    int[,] array = new int[FirstRow, FirstCol];
    for (int i = 0; i < FirstRow; i++)
    {
        for (int j = 0; j < FirstCol; j++)
        {
            array[i,j] = new Random().Next(-FirstRange, FirstRange + 1);
        }
    }
    return array;
}

int[,] generateSecondArray(int SecondRow, int SecondCol, int SecondRange)
{
    int[,] array = new int[SecondRow, SecondCol];
    for (int i = 0; i < SecondRow; i++)
    {
        for (int j = 0; j < SecondCol; j++)
        {
            array[i,j] = new Random().Next(-SecondRange, SecondRange + 1);
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

void MultArray(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] arrayMult = new int[arrayFirst.GetLength(0),arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraySecond.GetLength(1); k++)
            {
                arrayMult[i,j] = arrayMult[i,j] + arrayFirst[i,k] * arraySecond[k,j];
            }
            Console.Write(arrayMult[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int FirstRow = arraySizeFromUser("Введите количество строк 1-го массива");
int FirstCol = arraySizeFromUser("Введите количество столбцов 1-го массива");
int SecondRow = arraySizeFromUser("Введите количество строк 2-го массива");
int SecondCol = arraySizeFromUser("Введите количество столбцов 2-го массива");
Console.WriteLine("Сгенерированный 1-ый массив");
int[,] FirstArray = generateFirstArray(FirstRow, FirstCol, 4);
printArray(FirstArray);
Console.WriteLine("Сгенерированный 2-ой массив");
int[,] SecondArray = generateSecondArray(SecondRow, SecondCol, 4);
printArray(SecondArray);
Console.WriteLine("Результирующая матрица");
MultArray(FirstArray, SecondArray);