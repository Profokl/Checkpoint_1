// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

static void PrintNaturalSum(int M, int N)
{
    if (M <= 0 || N <= 0)
    {
        Console.WriteLine("M и N должны быть натуральными числами.");
        return;
    }

    if (M > N)
    {
        Console.WriteLine("M должно быть меньше или равно N.");
        return;
    }

    int sum = 0;

    for (int i = M; i <= N; i++)
    {
        sum += i;
    }

    Console.WriteLine(sum);
}

int M, N;
Console.Write("Введите значение M: ");
bool isValidM = int.TryParse(Console.ReadLine(), out M);

Console.Write("Введите значение N: ");
bool isValidN = int.TryParse(Console.ReadLine(), out N);

if (isValidM && isValidN)
{
    PrintNaturalSum(M, N);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

Console.ReadLine();