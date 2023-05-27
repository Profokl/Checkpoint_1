//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

static void PrintNaturalNumbers(int M, int N)
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

    for (int i = M; i <= N; i++)
    {
        Console.WriteLine(i);
    }
}

int M, N;
Console.Write("Введите значение M: ");
bool isValidM = int.TryParse(Console.ReadLine(), out M);

Console.Write("Введите значение N: ");
bool isValidN = int.TryParse(Console.ReadLine(), out N);

if (isValidM && isValidN)
{
    PrintNaturalNumbers(M, N);
}
else
{
    Console.WriteLine("Некорректный ввод.");
}

Console.ReadLine();