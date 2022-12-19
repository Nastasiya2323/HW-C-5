


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int FindLot(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = 8;
int[] array = CreateArray(size);
ShowArray(CreateArray(size));
int count = FindLot(array);
Console.WriteLine($"Количество четных чисел в массиве состоавляет {count}");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1     [1, 2, 3, 6, 2] -> 0     [10, 11, 12, 13, 14] -> 5

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int FindCount(int[] array)
// {
//      int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i] > 10 && array[i] < 99) count++;
//     }
//     return count;
// }

// int size = 123;
// int[] array = CreateArray(size);
// ShowArray(array);
// int count = FindCount(array);
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] состоавляет {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19   // [-4, -6, 89, 6] -> 0

// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// int FindLot(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             summ = summ + array[i];
//         }
//     }
//     return summ;
// }

// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите мин значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите макс знач: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size, min, max);
// ShowArray(CreateArray(size, min, max));
// int summ = FindLot(array);
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {summ}");

// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int[] NewArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] ResultArray(int[] array)
//     {
//         int n = array.Length;
//         int k = n / 2;
//         if (n % 2 != 0)
//             k++;
//         int[] resArray = new int[k];
//         if (n % 2 == 0)
//         {
//             for (int i = 0; i < k; i++) 
//             resArray[i] = array[i] * array[n - i - 1];
//         }
//         else
//         {
//             for (int i = 0; i < k; i++)
//             {
//                 if (i == k - 1)
//                     resArray[i] = array[i];
//                 else
//                     resArray[i] = array[i] * array[n - i - 1];
//             }
//         }
//     return resArray;
//     }

//     void ShowCreateResultArray(int[] resArray)
//     {
//         for (int i = 0; i < resArray.Length; i++)
//         {
//             Console.Write($"{resArray[i]} ");
//         }
//     }
    
//     int size = 5;
//     int min = 1;
//     int max = 10;
//     int[] array = NewArray(size, min, max);
//     ShowArray(array);
//     int[] resArray = ResultArray(array);
//     ShowCreateResultArray(resArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] DouArray(int size, double min, double max)
// {
//     double [] array = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round((new Random().NextDouble())*100, 2);

//         Console.Write($"{array[i]}, ");
//     }
//     return array;
// }

// double FindMmax(double[] array)
// {
//    double mmax = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > mmax)
//         {
//             mmax = array[i];
//         }
//     }
//     return mmax;
// }

// double FindMmin(double[] array)
// {
//     double mmin = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < mmin)
//         {
//             mmin = array[i];
//         }
//     }
//     return mmin;
// }

// int size = 5;
// double min = -100;
// double max = 100;
// double [] array = DouArray(size, min, max);
// double mmax = FindMmax(array);
// double mmin = FindMmin(array);
// Console.WriteLine($"Разница между максимальным {mmax} и минимальным {mmin} элементами массива составляет {Math.Round(mmax-mmin, 2)}");


// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int[] NewArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] ResultArray(int[] array)
//     {
//         int n = array.Length;
//         int k = n / 2;
//         if (n % 2 != 0)
//             k++;
//         int[] resArray = new int[k];
//         if (n % 2 == 0)
//         {
//             for (int i = 0; i < k; i++) 
//             resArray[i] = array[i] * array[n - i - 1];
//         }
//         else
//         {
//             for (int i = 0; i < k; i++)
//             {
//                 if (i == k - 1)
//                     resArray[i] = array[i];
//                 else
//                     resArray[i] = array[i] * array[n - i - 1];
//             }
//         }
//     return resArray;
//     }

//     void ShowCreateResultArray(int[] resArray)
//     {
//         for (int i = 0; i < resArray.Length; i++)
//         {
//             Console.Write($"{resArray[i]} ");
//         }
//     }
    
//     int size = 5;
//     int min = 1;
//     int max = 10;
//     int[] array = NewArray(size, min, max);
//     ShowArray(array);
//     int[] resArray = ResultArray(array);
//     ShowCreateResultArray(resArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] DouArray(int size, double min, double max)
// {
//     double [] array = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round((new Random().NextDouble())*100, 2);

//         Console.Write($"{array[i]}, ");
//     }
//     return array;
// }

// double FindMmax(double[] array)
// {
//    double mmax = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > mmax)
//         {
//             mmax = array[i];
//         }
//     }
//     return mmax;
// }

// double FindMmin(double[] array)
// {
//     double mmin = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < mmin)
//         {
//             mmin = array[i];
//         }
//     }
//     return mmin;
// }

// int size = 5;
// double min = -100;
// double max = 100;
// double [] array = DouArray(size, min, max);
// double mmax = FindMmax(array);
// double mmin = FindMmin(array);
// Console.WriteLine($"Разница между максимальным {mmax} и минимальным {mmin} элементами массива составляет {Math.Round(mmax-mmin, 2)}");
