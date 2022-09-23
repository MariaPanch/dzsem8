// Задача 2: Задайте две квадратные матрицы одного размера.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] array1 = { { 2, 4 }, { 3, 2 } };
int[,] array2 = { { 3, 4 }, { 3, 3 } };

ArrayToConsole(MultMatrix(array1, array2));

int[,] MultMatrix(int[,] array1, int[,] array2)
{
    int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            res[i, j] = sum;
        }
    }
    return res;
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

