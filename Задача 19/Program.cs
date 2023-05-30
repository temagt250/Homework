// Домашнее задание
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//      14212 -> нет
//      12821 -> да
//      23432 -> да

Console.Write("Введите пятизначное число: ");
var StringNumber = Console.ReadLine();
int Number;
bool IsNumber = int.TryParse(StringNumber, out Number);
if (IsNumber)
{
    if (StringNumber.Length == 5)
    {
        if (StringNumber [0] == StringNumber [4] && StringNumber [1] == StringNumber [3])
        {
            Console.Write("Да(Это палиндром)");
        }
        else
        {
            Console.Write("Нет");
        }
    }
    else
    {
        Console.Write("Введено не пятизначное число!");
    }
}
else
{
    Console.Write("Введено не число!");
}