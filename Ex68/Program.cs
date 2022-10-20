// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

int InputIntNumberM()
{
    while (true)
    try
        {
            Console.Write("Введите число M: ");
            int M = int.Parse(Console.ReadLine() ?? "0");
            return M;
        }
        catch 
        {
            Console.WriteLine("Введите целое число, пожалуйста");
        }
}

int InputIntNumberN()
{
    while (true)
    try
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine() ?? "0");
            return N;
        }
        catch 
        {
            Console.WriteLine("Введите целое число, пожалуйста");
        }
}

int M = InputIntNumberM();
int N = InputIntNumberN();

void Recursion(int M, int N)
{
    if (M > N)
    {
        M = M % N;
    }
    else
    {
        N = N % M;
    }
    if (M != 0 && N != 0)
    {
        Recursion(M, N);
    }
    else
    {
        Console.WriteLine("НОД "+ (M+N).ToString());
    }
}

Recursion(M, N);