// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ThreeDig (int n1)
{
    if(n1>100 && n1<1000)
    {
        int num = (n1 / 10) % 10;
        return num;
    }
    else 
    {
        Console.WriteLine("Error!!!");
        return n1;
    }
}

Console.WriteLine("Enter a three-digit number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int result = ThreeDig(n1);

Console.WriteLine($"Your number is {n1}, and the second digit is {result}");
// Не понял как сделать, чтобы когда число небыло трёхзначным строку 21 не выводить.
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Enter a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int Metod(int arg1)
{
while(n1 > 1000)
{
    n1 = n1 / 10;  
}
return n1;
}

if( n1 <= 99 ) 
{
Console.WriteLine("There is no third digit!");
}
else
{
int result = Metod(n1) % 10;
Console.WriteLine($"{result}");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Enter a number indicating the day of the week: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int monday = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;

if(n1 == saturday || n1 == sunday) Console.WriteLine("It's the weekend.");
else Console.WriteLine("It's not a weekend.");
*/