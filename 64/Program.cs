// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}


void PrintNumbersInRange(int start, int end)
{
    if (start <= end)
    {
        Console.Write(start);           
        if (start != end)
        {
            Console.Write(", ");
        }
            
        PrintNumbersInRange(start + 1, end);
    }
    else
    {
        Console.WriteLine();
    }
}

int a = Prompt("Введите число-старт: ");
int b = Prompt("Введите число-конец: ");
PrintNumbersInRange(a, b);