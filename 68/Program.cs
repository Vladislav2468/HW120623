// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}


int CalculateAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAckermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
    }
    else
    {
        throw new ArgumentException("недопустимые входные значения");
    }
}

int a = Prompt("Введите число ---> ");
int b = Prompt("Введите число ---> ");
int result = CalculateAckermann(a, b);
Console.WriteLine(result);