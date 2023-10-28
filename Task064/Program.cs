// Напишите программу, которая выводит все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии
Console.WriteLine("task 64\nВведите натуральное число: ");

int number = Convert.ToInt32(Console.ReadLine());

NaturalNumber(number);

void NaturalNumber(int num)
{
    if (num ==0) 
        return;
    Console.Write($"{num}");
    NaturalNumber(num-1);
}
