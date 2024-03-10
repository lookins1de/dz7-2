int Ackerman(int m, int n)
{ 
    if (m == 0) 
        return n + 1;
    else if (n == 0) 
        return Ackerman(m - 1, 1);
    else 
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Вы ошиблись!\nВведите неотрицательное число M: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Вы ошиблись!\nВведите неотрицательное число N: ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = {Ackerman(m, n)}");



