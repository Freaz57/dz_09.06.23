// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// double  [,] matrix = new double[rows, columns];



// void FillArray () {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = Convert.ToDouble((new Random().Next(-99,100))) / 10;
//         }
//     }
// }

// void PrintArray () {


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// FillArray ();
// PrintArray();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [5,5];

// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(1, 10);
//             }
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
       
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
        
//         Console.WriteLine(); 
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите кол-во строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int  [,] matrix = new int[rows, columns];



// void FillArray () {

    

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = (new Random().Next(1,10)) ;
//         }
//     }
// }



// void PrintArray () {


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + " ");
//         }

//         Console.WriteLine();
        
//     }
// }




// void AvarageArray() {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sum = (sum + matrix[j,i]);                       
            
//         }
//         sum = sum / rows;
//         Console.Write(sum + ";");
        

        
//     }

// }


// FillArray ();
// PrintArray();
// Console.WriteLine();
// AvarageArray();
// Console.WriteLine();



