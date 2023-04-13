// Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = SumAcc(m, n);
Console.WriteLine(res);

int SumAcc(int x1, int x2)
{
    if (x1 == 0) return x2+1;
    if (x1 > 0 && x2 == 0)
        return SumAcc(x1-1,1);
    else
        return SumAcc(x1-1,SumAcc(x1, x2-1));
}
