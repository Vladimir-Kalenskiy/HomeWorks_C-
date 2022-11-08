// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Grade(int a, int b)
// {
//     int result = a;
//     for(int i = 1; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }

// Console.Write("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input grade number B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Grade(a,b);

// Console.WriteLine($"A grade B = {Grade(a,b)}");

// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         int n = number % 10;
//         sum = sum + n;
//         number = number / 10;
//     }
//     return sum;
// }

// Console.Write("Input number A: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{Sum(a)}");

// Задача 29. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] UserArray(int size)
// {
//     int min = 0;
//     int max = 10;
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }

// Console.Write("Input size array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] userArray = UserArray(m);

// ShowArray(userArray);
