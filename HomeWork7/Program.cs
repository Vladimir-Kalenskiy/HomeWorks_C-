// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void Show2dArray(double[,] array, string msg = "Generated array")
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// double[,] CreateRandom2dArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     // double minValue = -10;
//     // double maxValue = 10;


//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = Math.Round(new Random().NextDouble(), 2);
    
//     return array;    
// }
 
// double[,] randArray = CreateRandom2dArray(m,n);
// Show2dArray(randArray);                                                                         // В задаче небыло условия воспроизвести массив, просто мне так удобнее

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray()
// {
//     int rows = 5;
//     int columns = 5;

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(1,10);
    
//     return array;    
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintElement(int m, int n, int[,] array)
// {
//     if( m < array.GetLength(0) && n < array.GetLength(1))
//         Console.WriteLine($"Element [{m},{n}] is {array[m,n]}.");
//     else
//         Console.WriteLine($"Error, the element [{m},{n}] - does not exist.");
// }

// Console.WriteLine("Enter the rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter the columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] randArray = CreateRandom2dArray();
// PrintElement(m,n,randArray);
// Console.WriteLine();
// Show2dArray(randArray);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray()
// {
//     int rows = 5;
//     int columns = 3;
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(1,10);
    
//     return array;    
// }

// void Show2dArray(int[,] array, string msg = "Generated array")
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowArray(double[] array)
// {
//     Console.WriteLine();
    
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// double[] ArithmeticMean(int[,] array)
// {
//     double[] arraySum = new double[array.GetLength(1)];
    

//     for(int j = 0; j < array.GetLength(1); j++)
//         {
//         double sum = 0;
//         for(int i = 0; i < array.GetLength(0); i++)
//             sum += array[i,j];
            
//         arraySum[j] = sum / array.GetLength(0);
//         }
//     return arraySum;
// }


// int[,] randArray = CreateRandom2dArray();
// Show2dArray(randArray);

// double[] resultArray = ArithmeticMean(randArray);
// ShowArray(resultArray);
