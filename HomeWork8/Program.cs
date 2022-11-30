int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array, string msg = "Generated array")
{
    Console.WriteLine(msg + "\n");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");

        Console.WriteLine('\n');
    }
    Console.WriteLine();
}

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void ArrangeElemint(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int l = j + 1; l < array.GetLength(1); l++)
//                 if (array[i, j] < array[i, l])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, l];
//                     array[i, l] = temp;
//                 }
// }

// ArrangeElemint(myArray);
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[] ArrayRowsSum(int[,] array)
// {
//     int[] arraySum = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         arraySum[i] = sum;
//     }
//     return arraySum;
// }

// int GetRows(int[] array)
// {
//     int result = 0;

//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < array[result])
//             result = i;
//     return result;
// }

// Console.WriteLine($"Minimal sum of elements in row number: {GetRows(ArrayRowsSum(myArray)) + 1}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] DivMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

//     if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
//     {
//         for (int i = 0; i < resultMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < resultMatrix.GetLength(1); j++)
//             {
//                 resultMatrix[i, j] = 0;
//                 for(int l = 0; l < firstMatrix.GetLength(1); l++)
//                 {
//                     resultMatrix[i,j] += firstMatrix[i,l] * secondMatrix[l,j];
//                 }
//             }
//         }
//         return resultMatrix;
//     }
//     else
//     {
//         Console.WriteLine("Error!!!");
//         return resultMatrix;
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);



// Console.Write("Input a number of rows 2: ");
// int m2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns 2: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a max possible value: ");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray2 = CreateRandom2dArray(m2, n2, min2, max2);

// Show2dArray(myArray);
// Show2dArray(myArray2);

// int[,] result = DivMatrix(myArray,myArray2);
// Show2dArray(result, "Div matrix");

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[] RandTwoDigitArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);

//         if(i > 0)
//             for(int j = 0; j < i; j++)
//                 while(array[i] == array[j])
//                     array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// int[,,] CreateRandom3dArray(int rows, int columns, int layers,int minValue = 10, int maxValue = 100)
// {
//     int[,,] array = new int[rows, columns, layers];
//     int[] randDigitArray = RandTwoDigitArray(rows*columns*layers, minValue,maxValue);
//     int tempIndex = 0;

//     if((rows*columns*layers)<(maxValue-minValue))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             for (int j = 0; j < array.GetLength(1); j++)
//                 for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     array[i, j, k] = randDigitArray[tempIndex];
//                     tempIndex++;
//                 }
//     return array;
//     }
//     else 
//     {
//         Console.WriteLine("Error!!!");
//         return array;
//     }
// }

// void Show3dArray(int[,,] array, string msg = "Generated array")
// {
//     Console.WriteLine(msg + "\n");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k =0; k < array.GetLength(2); k++)
//             {
//             Console.Write($"({i},{j},{k}): {array[i, j, k]}\t");   
//             }
//             Console.WriteLine('\n');
//         }
//     }
//     Console.WriteLine();
// }



// Console.Write("Input a number of rows: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of layers: ");
// int z = Convert.ToInt32(Console.ReadLine());



// int[,,] my3dArray = CreateRandom3dArray(x, y, z);
// Show3dArray(my3dArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// void SpiralFillArray(int[,] array)
// {
//     int i = 0;
//     int j = 0;
//     int temp = 0;

//     for (int l = 0; l < array.Length; l++)
//     {
//         array[i, j] = l + 1;

//         if (i == temp && j < array.GetLength(1) - temp - 1)
//             j++;
//         else if (j == array.GetLength(1) - temp - 1 && i < array.GetLength(0) - temp - 1)
//             i++;
//         else if (i == array.GetLength(0) - temp - 1 && j > temp)
//             j--;
//         else
//             i--;

//         if (i == (temp + 1) && j == temp && temp != (array.GetLength(1) - temp - 1))
//             temp++;
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = new int[m,n];
// SpiralFillArray(myArray);
// Show2dArray(myArray);