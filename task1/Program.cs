/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int userNumber = new int();
Console.WriteLine("Введите число");
userNumber = Convert.ToInt32(Console.ReadLine());

int sunOfNumbers (int userNumber)
{
    int result = 0;
    for (int i = userNumber; i > 0;)
    {
        result = result + i % 10;
        i = i / 10;
    }
    return result;
}
int result = sunOfNumbers(userNumber);
Console.WriteLine ($" Сумма цифр в числе {userNumber} = {result}");
