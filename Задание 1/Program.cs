/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> дa
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string numberStr=Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int number1 = number / 10000;
int number2 = number % 10000 / 1000;

int number4 = number % 100 / 10;
int number5 = number % 10;


if (number1 == number5 && number2 == number4)
    
    {
        Console.WriteLine("палиндром");
    }

else
{
    Console.WriteLine("Не палиндром");
}