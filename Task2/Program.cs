/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

string DigitsFromMToN(int m, int n)
{
    if (n == m)
    return $"{m}";

    string result = DigitsFromMToN(m, n-1) + " " + n;
    return result;
}

int SumDigitsFromMToN (int m, int n)
{
    if (n == m)
    return m;

    int sum = n + SumDigitsFromMToN(m, n-1);
    return sum;
}

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Натуральные числа от M до N: ");
string difits = DigitsFromMToN(m, n);
Console.WriteLine($"{difits}");

Console.WriteLine("Сумма чисел от M до N: ");
int sum = SumDigitsFromMToN (m, n);
Console.WriteLine($"{sum}");