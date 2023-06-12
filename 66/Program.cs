// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}


int GetSumOfNaturalNumbers(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + GetSumOfNaturalNumbers(start + 1, end);
    }
}


int a = Prompt("Введите число-старт: ");
int b = Prompt("Введите число-конец: ");


int sum = GetSumOfNaturalNumbers(a, b);
Console.WriteLine(sum);
