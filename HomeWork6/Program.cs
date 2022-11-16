int[] UserArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Generated array: ");
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int PositiveNumbers(int size)
// {
//     int count = 0;
//     for(int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Enter the number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if( num > 0) count++;
//     }
            
//     return count;
// }

// Console.WriteLine("Enter the number of numbers: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Positive numbers : {PositiveNumbers(m)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//            значения b1, k1, b2 и k2 задаются пользователем.

// void Point(double b, double k, double b1, double k1)
// {
//     double x = (b1 - b)/(k - k1);
//     double y = k*(b1 - b)/(k - k1) + b;
//         if (k == k1 && b == b1)
//         {
//             Console.WriteLine("Прямые совпадают");
//             return;
//         }    
//         else if(k==k1)
//         {
//             Console.WriteLine("Прямые параллельны");
//             return;
//         }
//         else
//             Console.WriteLine($"Point : ( {x} ; {y} )"); 
// }

// Console.WriteLine("Enter a value b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter a value k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter a value b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Enter a value k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// Point(b1,k1,b2,k2);
