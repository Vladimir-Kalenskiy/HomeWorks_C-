// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Palindrome(int arg) 
{ 
    if(arg / 100000 == 0 && arg >= 10000) 
        { 
            if(arg/10000 == arg % 10) 
                 if((arg/1000)%10 == (arg % 100)/10) 
                     Console.WriteLine("Number is a palindromenumber."); 
                 else Console.WriteLine("Number is not a palindromenumber."); 
            else Console.WriteLine("Number is not a palindromenumber."); 
        } 
else Console.WriteLine("Error! This is number is not five-digit!"); 
} 
 
Console.Write("Enter a five-digit number: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
Palindrome(n);
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int cur1 = x2 - x1;
    int cur2 = y2 - y1;
    int cur3 = z2 - z1;

    double dis = Math.Round((Math.Sqrt(cur1*cur1 + cur2*cur2 + cur3*cur3)), 2);
    return dis;
}

Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dis = Distance(x1,y1,z1,x2,y2,z2);

Console.WriteLine("Distance is " + dis);
/*

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int number)
{
    int index = 1;
    while(index <= number)
    {
        double res = Math.Pow(index, 3);
        Console.Write(res + " ");
        index++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/