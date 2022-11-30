/*
Задача 28: Напишите программу,
 которая принимает на вход число N 
 и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/

int degree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i<= numberB; i++)
    {
        result = result * numberA; 
    }    
    return result;
}
int numberA = new int();
Console.WriteLine("Введите число");
numberA = Convert.ToInt32(Console.ReadLine());
 int numberB = new int();
Console.WriteLine("Введите  степень");
numberB = Convert.ToInt32(Console.ReadLine());

    int result = degree(numberA,numberB);
    Console.WriteLine($" Число  {numberA} в {numberB} степени = {result}");

