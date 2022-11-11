// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве. [345, 897, 568, 234] => 2
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:  ");

        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];

        FillArrayRandomNumbers(numbers);

        Console.WriteLine("массив: ");
        PrintArray(numbers);
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 2 == 0)
                count++;

        Console.WriteLine($" В массиве {count} чётных чисел ");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100, 1000);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
*/
// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
/*
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintArray(numbers);
        int sum = 0;

        for (int z = 1; z < numbers.Length; z += 2)
            sum = sum + numbers[z];

        Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

        void FillArrayRandomNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1, 10);
            }
        }
        void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
*/
/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[size];
        FillArrayRandomNumbers(numbers);
        PrintArray(numbers);

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            else if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Минимальное число: {min}");
        Console.WriteLine($"Минимальное число: {max}");
        Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");

        void FillArrayRandomNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
            }
        }
        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        } 
    }
}
*/
/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[size];
        FillArrayRandomNumbers(numbers);
        Console.WriteLine("Вот наш массив: ");
        PrintArray(numbers);
        double min = Int32.MaxValue;
        double max = Int32.MinValue;

        for (int z = 0; z < numbers.Length; z++)
        {
            if (numbers[z] > max)
            {
                max = numbers[z];
            }
            if (numbers[z] < min)
            {
                min = numbers[z];
            }
        }

        Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
        Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

        void FillArrayRandomNumbers(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
            }
        }
        void PrintArray(double[] numbers)
        {
            Console.Write("[ ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
*/
