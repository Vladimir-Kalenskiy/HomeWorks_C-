/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);

int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/

// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int LargetDigit(int number)
{
    int firstDigit = number /10;
    int lastDigit = number % 10;
    if(firstDigit > lastDigit) 
    {
        int result = firstDigit;
        return result;
    }
    else
    {
        int result = lastDigit;
        return result;
    }
}

int number = new Random().Next(10, 100);

Console.WriteLine(LargetDigit(number));
*/
// Задача 2. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
/*
bool IsSquare(int firstInt, int secondInt)
{
    if(firstInt == secondInt * secondInt || secondInt == firstInt * firstInt) return true;
    else return false;
}

int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);

Console.WriteLine(result);
*/
// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool IsDiv(int firstInt, int secondInt)
{
    if(secondInt % firstInt == 0) return true;
    else return false;
}

int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDiv(number1, number2);
Console.WriteLine(result);
*/
// Задача 4. Напишите программу, которая принимает на вход три целых числа(a, m, n) и проверяет, кратно ли число a одновременно m и n.
