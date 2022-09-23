// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел 
//(размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

int m = 5;
int n = 5;
int CurElement=0;
int[,] array = new int[m, n];
FillDifferentArray(array);
ArrayToConsole(array);

void FillDifferentArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetNewValue(array,CurElement);
            CurElement++; 
        }
    }
}


int GetNewValue(int[,] array, int CurElement)
{
    Random rnd = new Random();
    int value = rnd.Next(10, 99);
    while (Contains(array, value, CurElement))
    {
        value = rnd.Next(10, 99);
    }
    return value;
}

bool Contains(int[,] array, int value, int CurElement)
{
    
    int Cur=0;
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            if (array[i,j] == value) return true;
            if (Cur==CurElement) return false;
            Cur++;
        }
    }
    return false;
}

void ArrayToConsole(int [,] array)
{
    int [] buf = new int[array.GetLength(1)];
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            buf[j] = array[i,j];
        }
        System.Console.WriteLine("[{0}]", string.Join(", ", buf));
    }
}