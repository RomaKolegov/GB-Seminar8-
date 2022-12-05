/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int arraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int numbersFromUser = Convert.ToInt32(Console.ReadLine());
    return numbersFromUser;
}

int[,] generateInitialArray(int Row, int Col, int range)
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

void generateSortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxIndex = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    maxIndex = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = maxIndex;
                }
            }
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int Row = arraySizeFromUser("Введите количество строк массива");
int Col = arraySizeFromUser("Введите количество столбцов массива");
Console.WriteLine("Сгенерированный массив");
int[,] initialArray = generateInitialArray(Row, Col, 10);
printArray(initialArray);
Console.WriteLine("Отсортированный на убывание по строкам массив");
generateSortedArray(initialArray);
