// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a1 = num / 10000;
int a2 = (num / 1000) % 10;
// int a3 = (num / 100) % 10;
int a4 = (num / 10) % 10;
int a5 = num % 10;

if (num < 10000 || num > 99999) Console.WriteLine("!!!Не корректное число!!!");
else
{
    if (a1 == a5 && a2 == a4) Console.WriteLine($"Число {num} -> является палиндромом ");
    else if (a1 != a5 && a2 != a4) Console.WriteLine($"Число {num} -> не является палиндромом ");
}

