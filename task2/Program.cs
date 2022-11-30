/*Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] CreateArray(int N, int min,int max)
{
    int[]array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i]=new Random().Next(min,max+1);
    }
return array;
}
void PrintArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int N = 8;
int min = 0;
int max = 99;
int[]array = CreateArray(N,min,max);
PrintArray(array);

