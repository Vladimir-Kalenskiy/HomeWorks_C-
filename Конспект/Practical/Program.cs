// Задача 1.1. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадрадтом второго.

/*
Console.WriteLine("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(quad2 == n1)
{
    Console.WriteLine($"Number {n1} is square of {n2}");
}
else
{
    Console.WriteLine($"Number {n1} is not a square of {n2}");
}
*/

// Задача 1.2. Напишите программу, которая принимает на вход одно число n, а на выходе показывает все промещутки от -n до n.

/*
Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 1.3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}.");
*/

// Задача 2.1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100,1000);

int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/

// Задача 2.2 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxDigit(int number)
{
    int firstNum = number / 10;
    int secondNum = number % 10;

    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}

int number = new Random().Next(10,100);

int result = MaxDigit(number);

Console.WriteLine($"Given the number {number} the largest digit is {result}.");
*/
// Задача 2.3 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool Quad(int n1, int n2)
{
    if(n1 == n2 * n2 || n2 == n1*n1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool result = Quad(n1, n2);

Console.WriteLine($"First number is the square of the second number? -{result}");
*/
// Задача 2.4 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool Multiple(int n1,int n2)
{
    if(n2 % n1 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool result = Multiple(n1,n2);

Console.WriteLine($"The second number is a multiple of the first? -{result}");
*/

// Задача 2.5 Напишите программу, которая принимает три целых числа(a, m, n) и проверяет, кратно ли число a одновременно m и n.
/*
bool Proverka(int arg1, int arg2, int arg3)
{
    if( arg1 % arg2 == 0 && arg1 % arg3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input kratnoe 1: ");
int argN = Convert.ToInt32(Console.ReadLine());

Console.Write("Input kratnoe 2: ");
int argM = Convert.ToInt32(Console.ReadLine());

bool result = Proverka(num, argN, argM);

Console.WriteLine($"Number {num} kratno 1 and 2? -{result} ");
*/

// Задача 3.1 Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void ShowQuart (int quartNum)
{
    if(quartNum >= 1 && quartNum <= 4)
    {
        if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if(quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if(quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else
    {
        Console.WriteLine("Error!!!");
    }
}

Console.WriteLine("Input a number of quart: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);
*/

// Задача 3.2 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int ShowQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y: ");
double y = Convert.ToDouble(Console.ReadLine());

int result = ShowQuart(x,y);

Console.WriteLine($"Point A is in {result} quarter");
*/

// Задача 3.3 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double Distence(double xa, double ya, double xb, double yb)
{
double distance = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya -yb), 2));
return distance;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round((Distence(x1,y1,x2,y2)), 2);

Console.WriteLine($"Distance is {distance}.");
*/

// Задача 3.4 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void Quad(int argN)
{
   int index = 1;
   while(index <= argN)
   {
    double result = Math.Pow(index,2);
    Console.Write(result + " ");
    index++;
   }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

Quad(n);
*/

