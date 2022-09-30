/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить 
с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string DigitsToN(int n)
{
    if (n == 1)
    return "1";

    string result = n + " " + DigitsToN(n-1);
    return result;
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Натуральные числа от 1 до N: ");
string digits = DigitsToN(n);
Console.WriteLine($"{digits}");
