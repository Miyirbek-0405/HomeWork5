// =============================== start =====================================

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
Console.Write("Print number: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArr(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

int PrintEvenArrayNumbers(int[] array)
{
    int cout = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            cout++;
        }
    }
    return cout;
}

int [] arr=NewArr(number);
int printResult=PrintEvenArrayNumbers(arr); 
PrintArr(arr);
Console.WriteLine(printResult);
*/

// ================================== end =====================================

// =============================== start =====================================

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
Console.Write("PrintNum: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("PrintMin: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("PrintMax: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int number, int min, int max)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintRandomArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

int SumRandomArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] randArr = RandomArray(num, min, max);
int sumOddIndexArray = SumRandomArray(randArr);
PrintRandomArray(randArr);
Console.WriteLine(sumOddIndexArray);
*/

// ================================== end =====================================

// =============================== start =====================================

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

Console.Write("PrintNum: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("PrintMin: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("PrintMax: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] RealArray(int number, int min, int max)
{
    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(min, max + 1);
    }
    return array;
}

void PrintRealArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)}; ");
    }
    Console.WriteLine("\b\b]");
}

double DiffMaxMinElemArray(double[] array)
{
    int max_i = 0;
    int min_i = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max_i])
        {
            max_i = i;
        }
        else if (array[i] < array[min_i])
        {
            min_i = i;
        }
    }
    return Math.Round(array[max_i] - array[min_i], 2);
}

double[] realArr = RealArray(num, min, max);
double diffElemArr = DiffMaxMinElemArray(realArr);
PrintRealArray(realArr);
Console.WriteLine(diffElemArr);


// ================================== end =====================================