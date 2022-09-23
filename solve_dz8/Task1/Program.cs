// Задача 1: Задайте двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Номер строки с наименьшей суммой элементов: 1 строка
//(допускается указывать индекс строки в массиве, в данном примере - 0)

int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
ArrayToConsole(array);
System.Console.WriteLine(GetRowWithMinSumm(array));

int GetRowWithMinSumm(int[,] array)
{
    int MinIndex = 0;
    int Sum = 0;
    int SumMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i, j];
        }
        if (i == 0)
        {
            SumMin = Sum;
        }
        else
        {
            if (SumMin > Sum)
            {
                SumMin = Sum;
                MinIndex = i;
            }
        }
    }
    return MinIndex;
}



void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void ArrayToConsole(int[,] array)
{
    int[] buf = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            buf[j] = array[i, j];
        }
        System.Console.WriteLine("[{0}]", string.Join(", ", buf));
    }
}

