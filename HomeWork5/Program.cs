// int[] UserArray(int size, int min, int max)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Generated array: ");
    
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.Write("Enter a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a minimal possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a maximal possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] UserArray(int size)
// {
//     int min = 100;
//     int max = 1000;
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     Console.WriteLine("Generated array: ");
    
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int QuantityEvenNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if((array[i] % 2) == 0)
//             count++;
//     return count;
// }

// Console.Write("Enter a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] randArray = UserArray(num);
// ShowArray(randArray);

// int result = QuantityEvenNumbers(randArray);

// Console.WriteLine($"Quantity even numbers in array:  {result}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.

// int[] UserArray(int size)
// {
//     int min = 1;
//     int max = 1000;
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     Console.WriteLine("Generated array: ");
    
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int SumDigitNotEven (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//         if((i % 2) == 1)
//             sum = sum + array[i];
//     return sum;        
// }

// Console.Write("Enter a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] randArray = UserArray(num);
// ShowArray(randArray);

// int result = SumDigitNotEven(randArray);
// Console.WriteLine($"Сумма чисел нечетных элементов ровняется {result}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] UserArray(int size)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(new Random().NextDouble(), 2);
//     }
//     return array;
// }
// void ShowArray(double[] array)
// {
//     Console.WriteLine("Generated array: ");
    
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// double DifDigit(double[] array)
// {
//     double result = 0;
//     double min = 1;
//     double max = 0;
//     for(int i = 0; i < array.Length; i++)
        
//         if(array[i] > max)
//         {
//             max = array[i];
//         }
//         else
//         {
//             if (array[i] < min)
//                 min = array[i];
//         }
//         result = max - min;
//     return result;
// }

// Console.Write("Enter a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// double[] randArray = UserArray(num);
// ShowArray(randArray);

// double dif = DifDigit(randArray);

// Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {dif}");