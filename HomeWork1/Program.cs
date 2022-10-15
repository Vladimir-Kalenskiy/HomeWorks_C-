// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second a number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if ( n1 > n2) 
{
    int max = Convert.ToInt32(n1);
    int min = Convert.ToInt32(n2);
    Console.WriteLine($"The first number {n1} is greater then the second number {n2}.");
}
else
{
    int max = Convert.ToInt32(n2);
    int min = Convert.ToInt32(n1);
    Console.WriteLine($"The second number {n2} is greater then the first number {n1}.");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int num = n1;
int current = n2;

if(num > current)
{
    if(num > n3)
    {
        Console.WriteLine($"The first number {n1} is the maximum.");
    }
    else
    {
        Console.WriteLine($"The third number {n3} is the maximum.");
    }
}
else
{
    if(current > n3)
    {
        Console.WriteLine($"The second number {n2} is the maximum.");
    }
    else
    {
        Console.WriteLine($"The third number {n3} is the maximum.");
    }
}
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if((num % 2) == 1)
{
    Console.WriteLine($"This number {num} is not even.");
}
else
{
    Console.WriteLine($"This number {num} is even.");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

int step = 1;
int current = 2;

while(current <= N)
{
    if( current % 2 == 0)
    {
        Console.Write(current + " ");
        current = current + step;
    }
    else
    {
        current = current + step;
    }
}
*/