/*
* Урок 1. Знакомство с языком программирования С#
* 
* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
* какое число большее, а какое меньшее.
*
* a = 5; b = 7 -> max = 7
* a = 2 b = 10 -> max = 10
* a = -9 b = -3 -> max = -3
*
* Решение:
*/

Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());

double max = num1;
double min = num1;

if (num2 > num1)
{
    max = num2;
}
if (num2 < num1)
{
    min = num2;
}

Console.WriteLine("Большее число: " + max);
Console.WriteLine("Меньшее число: " + min);

/*
* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
* максимальное из этих чисел.
*
* 2, 3, 7 -> 7
* 44 5 78 -> 78
* 22 3 9 -> 22
*
* Решение:
*/

Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третье число");
double num3 = Convert.ToDouble(Console.ReadLine());

double max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("Максимальное число: " + max);

/*
* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
* является ли число чётным (делится ли оно на два без остатка).
*
* 4 -> да
* -3 -> нет
* 7 -> нет
*
* Решение:
*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

/*
* Задача 8: Напишите программу, которая на вход принимает число (N),
* а на выходе показывает все чётные числа от 1 до N.
*
* 5 -> 2, 4
* 8 -> 2, 4, 6, 8
*
* Решение:
*/

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

/*
* Из условий видно, что отрицательные чётные числа, 
* а также чётное число 0 показывать не нужно.
*/
if (n < 2)
{
    Console.WriteLine("пустое множество");
}
else
{
    string result = "2";
    int index = 4;

    while (index < n)
    {
        result += (", " + index);
        index = index + 2;
    }

    Console.WriteLine("Чётные числа от 1 до N: " + result);
}

/*
* Задача 5: Напишите программу, которая на вход принимает одно число (N),
* а на выходе показывает все целые числа в промежутке от -N до N.
*
* 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
* 2 -> " -2, -1, 0, 1, 2"
*
* Решение:
*/

Console.WriteLine("Введите число N");
int nPos = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int nNeg = -nPos;

string result = Convert.ToString(nNeg);
int index = nNeg + 1;

while (index <= nPos)
{

    result += (", " + index);
    index++;
}

Console.WriteLine("Целые числа от -N до N: " + result);

/*
* Задача 7: Напишите программу, которая принимает на вход трёхзначное число
* и на выходе показывает последнюю цифру этого числа.
* 456 -> 6
* 782 -> 2
* 918 -> 8
*
* Решение:
*/

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("Введено некорректное значение");
}
else
{
    int lastDigit = num % 10;

    Console.WriteLine("Последнюя цифра числа: " + lastDigit);
}