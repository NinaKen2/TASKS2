// Задача 66
//Задайте значения M и N. Напишите программу, 
//которая найдет сумму натуральных элементов 
//в промежутке от  M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15  ->120

Console.WriteLine("task 66");
Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{    
    int tmp = n;
    n = m;
    m = tmp;
}

Console.Write($"{SumBetween(m, n)}");

int SumBetween(int m, int n)
{
    if (m == n) 
        return m;
    return n + SumBetween(m, n-1);
}