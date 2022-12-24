// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Enter int n: ");
// int n = Convert.ToInt32 (Console.ReadLine());

// string NaturalInt(int n)
// {
//     if (n <= 1) return "1";
//     else return $"{n}, " + NaturalInt(n-1);
    
// }
// Console.Write($"{NaturalInt(n)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Enter int m: ");
// int m = int.Parse (Console.ReadLine());

// Console.WriteLine("Enter int n: ");
// int n = int.Parse (Console.ReadLine());

// System.Console.WriteLine($"{SumInt(m, n)} ");

// int SumInt(int m, int n)
// {
//     if (n >= m) return m + SumInt(m+1, n);
//     else return 0;
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Enter int m: ");
int m = int.Parse (Console.ReadLine());

Console.WriteLine("Enter int n: ");
int n = int.Parse (Console.ReadLine());

System.Console.WriteLine($"{Akkerman(m, n)} ");

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}