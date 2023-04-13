// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = SumNumbers(m, n);
Console.WriteLine(res);

int SumNumbers(int x1, int x2)
{
    if (x1 == x2) return x2;
    return x1 + SumNumbers(x1+1, x2);
}

