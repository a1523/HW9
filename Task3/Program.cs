/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction (int numb1, int numb2)
{
    if (numb1 == 0) return numb2 + 1;
    if (numb1 != 0 && numb2 == 0) return AckermannFunction(numb1 - 1, 1);
    if (numb1 > 0 && numb2 > 0) return AckermannFunction(numb1 - 1, AckermannFunction(numb1, numb2 - 1));
return AckermannFunction(numb1, numb2);
}

Console.WriteLine("Введите число m:");
int numb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n:");
int numb2 = int.Parse(Console.ReadLine());

int result = AckermannFunction(numb1, numb2);
Console.WriteLine($"Функция Аккермана для чисел {numb1} и {numb2} = {result}");