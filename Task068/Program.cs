// Задача 68
//Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа 
//m и n. Выполнить с помощью рекурсии.
//m =21; N = 3  -> A(m,n) = 9

Console.WriteLine("task 68");
Console.WriteLine("Введите неотрицательное целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m==0)
        return n + 1;
    if (m>0 && n==0)
        return akkerman(m-1, 1);
    //if (m>0 && n > 0)
    return akkerman(m-1, akkerman(m,n-1));
}

Console.Write($"{akkerman(m, n)}");