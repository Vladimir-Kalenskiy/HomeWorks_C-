// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// int Rekursi(int n)
// {
//     if (n == 1) return n;
//         else if (n > 1) 
//         {
//             Console.Write($"{n}  ");
//             return Rekursi(n - 1);
//         }
//         else 
//         {
//             Console.Write($"{n}  ");
//             return Rekursi(n + 1);
//         }   
// }

// Console.WriteLine("Input n number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{Rekursi(n)} ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumDigit(int m, int n)
// {
//     if (m > n) return SumDigit(m, n + 1) + n;
//     else if (n > m) return SumDigit(m + 1, n) + m;
//     else return m;
// }

// Console.WriteLine("Input m number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumDigit(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m,int n)
// {
//    if(m == 0) return n + 1;
//    else if(n == 0) return Akkerman(m-1,1);
//    else return Akkerman(m-1,Akkerman(m,n-1));
// }

// Console.WriteLine("Input m number is not negative: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n number is not negative: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Akkerman(m, n));