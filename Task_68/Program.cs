// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int M, N;
Console.Write("Введите значение M: ");
bool isValidM = int.TryParse(Console.ReadLine(), out M);

Console.Write("Введите значение N: ");
bool isValidN = int.TryParse(Console.ReadLine(), out N);

if (isValidM && isValidN)
{
    int result = Ackermann(M, N);
    Console.WriteLine($"Результат функции Аккермана: {result}");
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

Console.ReadLine();