// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int FillandEven (int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     int even = 0;
//     while (index < length)
//     {
//         array[index] = new Random().Next(100, 1000);
//         if (array[index] % 2 == 0)
//         {
//             even++;
//         }
//         index++;
//     }
//     return even;
// }

// void PrintArr(int[] Array1)
// {
//     int count = Array1.Length;
//     int pos = 0;
//     Console.Write("[ ");
//     while (pos < count)
//     {
//         Console.Write($"{Array1[pos]} ");
//         pos++;
//     }
// Console.Write("]");
// }


// int LenArr = new Random().Next(5, 16);
// int []arr = new int[LenArr];
// int K = FillandEven(arr);
// PrintArr(arr);
// Console.WriteLine($"Количество чётных чисел = {K}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArr(int[] array)
// {
//     int length = array.Length;
//     int index = 0;
//     Console.Write("[ ");
//     while (index < length)
//     {
//         array[index] = new Random().Next(-99, 100);
//         index++;
//     }
// }

// void PrintArr(int[] Array1)
// {
//     int count = Array1.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write($"{Array1[pos]}  ");
//         pos++;
//     }
//     Console.Write("]");
// }

// void Sum(int[] Array2)
// {
//     int SumofNum = 0;
//     for (int i = 1; i < Array2.Length; i+= 2)
//     {
//         SumofNum += Array2[i]; 
//     }
//     Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях = {SumofNum}");
// }

// int LenArr = new Random().Next(5, 11);
// int []arr = new int[LenArr];
// FillArr(arr);
// PrintArr(arr);
// Console.WriteLine();
// Sum(arr);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void DoubleFillArr(double[] array)
{
    Random rnd = new Random();
    int length = array.Length;
    int index = 0;
    Console.Write("[ ");
    while (index < length)
    {
        array[index] = new Random().Next(0, 10) + rnd.NextDouble();
        index++;
    }
}

void PrintArr(double[] Array1)
{
    int count = Array1.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write($"{Math.Round(Array1[pos],2)}  ");
        pos++;
    }
    Console.Write("]");
}

void Diff(double[] Array2)
{
    double Max = Array2[0];
    double Min = Array2[0];
    for (int i = 1; i < Array2.Length; i++)
    {
       if (Array2[i] > Max)
       {
        Max = Array2[i];
       }
       else if (Array2 [i] < Min)
       {
        Min = Array2[i];
       }
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(Max-Min, 2)}");
}

int LenArr = new Random().Next(5, 11);
double []arr = new double[LenArr];
DoubleFillArr(arr);
PrintArr(arr);
Console.WriteLine();
Diff(arr);