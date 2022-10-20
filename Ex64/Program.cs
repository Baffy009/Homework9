// Задача 64: Задайте значение N и M. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.

int InputIntNumberM()
{
    while (true)
    try
        {
            Console.Write("Введите значение M: ");
            int M = int.Parse(Console.ReadLine() ?? "0");
            return M;
        }
        catch 
        {
            Console.WriteLine("Введите натуральное число");
        }
}

int InputIntNumberN()
{
    while (true)
    try
        {
            Console.Write("Введите значение N: ");
            int N = int.Parse(Console.ReadLine() ?? "0");
            return N;
        }
        catch 
        {
            Console.WriteLine("Введите натуральное число");
        }
}

int M = InputIntNumberM();
int N = InputIntNumberN();

string NumbersRecUp(int M, int N) 
{  
    if (M % 2 == 0)
    {
        if (M < N) return $"{M} " + NumbersRecUp(M + 2, N);
        else return String.Empty;
    }
    else
    {
        if (M < N) return $"{M + 1} " + NumbersRecUp(M + 2, N);
        else return String.Empty;   
    }
}

string NumbersRecDown(int M, int N) 
{
    if (M % 2 == 0)
    {
        if (N < M) return $"{M} " + NumbersRecDown(M - 2, N);
        else return String.Empty;
    }
    else
    {
        if (N <= M) return $"{M - 1} " + NumbersRecDown(M - 2, N);
        else return String.Empty;   
    }
}


Console.WriteLine($"M = {M}, N = {N}");
Console.WriteLine();

if (N >= M)
{
    Console.WriteLine(NumbersRecUp(M, N));
}
else
{
    Console.WriteLine(NumbersRecDown(M, N));
}