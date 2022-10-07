//                                          Задача 10:
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//                                      вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if ((number < 99) || (number > 1000))
{
    Console.WriteLine("Вы ввели значение не входящее в заданый диапазон, необходимо ввести трехзначное число.");
}

int num1 = number / 10;
int num2 = num1 % 10;

Console.WriteLine($"Вторая цифра числа это: {num2}");



//                                          Задача 13: 
//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//                                    что третьей цифры нет.

Console.WriteLine("Введите число (максимальное число 100'000): ");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 > 100000)
{
    Console.WriteLine("Вы ввели значение не входящее в заданый диапазон.");
}
if (number2 < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
if ((number2 > 99) && (number2 < 1000))
{
    int no1 = number2 % 10;
    Console.WriteLine($"Третья цифра это: {no1}");
}
if ((number2 > 999) && (number2 < 10000))
{
    int del1 = number2 / 10;
    int no1 = del1 % 10;
    Console.WriteLine($"Третья цифра это: {no1}");
}
if ((number2 > 9999) && (number2 < 100000))
{
    int del1 = number2 / 100;
    int no1 = del1 % 10;
    Console.WriteLine($"Третья цифра это: {no1}");
}
if (number2 == 100000)
{
    int del1 = number2 / 1000;
    int no1 = del1 % 10;
    Console.WriteLine($"Третья цифра это: {no1}");
}


//                                          Задача 15: 
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//                        и проверяет, является ли этот день выходным.



Console.WriteLine("Введите цифру, обозначающую день недели: ");
int week = int.Parse(Console.ReadLine()!);

if ((week == 6) || (week == 7))
{
    Console.WriteLine("Ура! Ура! Это выходной!!!");

}
if (week < 1 || week > 7 && week != 6 && week != 7)
{
    Console.WriteLine("В неделе только 7 дней, пожалуйста введите цифру от 1 до 7, соответствующую дням недели от понедельника до воскресенья.");
}
if (week > 0 && week < 6)
{
    Console.WriteLine("Не выходной, иди работать!");
}
