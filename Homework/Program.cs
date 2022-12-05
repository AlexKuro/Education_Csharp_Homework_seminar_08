namespace Homework;
class Program
{
    static void Main(string[] args)
    {
        void Task54()
        {
            /* Задача 54. Задайте двумерный массив. 
            Напишите программу, которая упорядочит по убыванию элементы 
            каждой строки двумерного массива. */
            Console.WriteLine("     - -Задача 54- -");
            Console.WriteLine("Двумерный массив заполненный случайными числами:");
            int row = 5;
            int columns = 5;
            int[,] numbers = new int[row, columns];

            FillArray(numbers, 0, 20);
            PrintArray2(numbers);
            SortTwoArrayRow(numbers);
            Console.WriteLine("Сортировка строк двухмерного массива по убыванию:");

            PrintArray2(numbers);
        }

        void Task56()
        {
            /* Задача 56. Задайте прямоугольный двумерный массив. 
            Напишите программу, которая будет находить строку с наименьшей суммой элементов. */
            Console.WriteLine("              - -Задача 56- -");
            Console.WriteLine("Двумерный массив заполненный случайными числами:");
            Console.WriteLine();
            int row = 5;
            int columns = 5;
            int[,] numbers = new int[row, columns];
            FillArray(numbers, 0, 10);
            PrintArray2(numbers);
            Console.WriteLine();
            MinNumColumnTwoArray(numbers);
        }

        void Task58()
        {
            /* Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.

            01 02 03 04
            12 13 14 05
            11 16 15 06
            10 09 08 07 */
            int row = 4;
            int columns = 4;
            int[,] numbers = new int[row, columns];
            int index = 1;
            int i = 0;
            int j = 0;

            //Console.WriteLine($"({i}, {j})");
            //1
            for (j = 0; j < 4; j++)
            {
                numbers[i, j] = index++;
            }
            //2
            for (i = 1; i < j; i++)
            {

                numbers[i, j - 1] = index++;
            }
            //3
            for (j = 2; i - 4 <= j ; j--)
            {
                numbers[i - 1, j] = index++;
            }
            //4
            for (i = 2; i > j + 1; i--)
            {
                numbers[i, j + 1] = index++;
            }
            //5
            for (j = 1; j < 3; j++)
            {
                numbers[i + 1, j] = index++;
            }
            //6
            for (j = 2; j > 0; j--)
            {
                numbers[i + 2, j] = index++;
            }

            PrintArray2(numbers);

        }

        void MinNumColumnTwoArray(int[,] numbers)
        {
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            int[] result = new int[row];
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum = sum + numbers[i, j];
                }
                result[i] = sum;
                sum = 0;
            }

            int minValue = result[0];
            int minColumn = 0;
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] < minValue)
                {
                    minValue = result[i];
                    minColumn = i;
                }
            }
            Console.Write("Сумма каждой строки по порядку -> ");
            PrintArray1(result);
            Console.WriteLine();

            for (int j = 0; j < columns; j++)
            {
                result[j] = numbers[minColumn, j];
            }

            Console.Write($"Cтрока по адресу {minColumn} с наименьшей суммой элементов -> ");
            PrintArray1(result);
            Console.WriteLine();

        }

        void SortArray(int[] arraySort)
        {
            int temp = 0;

            for (int i = 0; i < arraySort.Length - 1; i++)
            {
                for (int j = i + 1; j < arraySort.Length; j++)
                {
                    if (arraySort[i] < arraySort[j])
                    {
                        temp = arraySort[i];
                        arraySort[i] = arraySort[j];
                        arraySort[j] = temp;
                    }
                }
            }
        }

        void SortTwoArrayRow(int[,] numbers)
        {
            int temp = 0;
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    for (int t = j + 1; t < columns; t++)
                    {
                        if (numbers[i, t] > numbers[i, j])
                        {
                            temp = numbers[i, t];
                            numbers[i, t] = numbers[i, j];
                            numbers[i, j] = temp;
                        }
                    }

                }
            }
        }

        void FillArray(int[,] numbers, int minValue, int maxValue)
        {
            maxValue++;
            Random rand = new Random();
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    numbers[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }

        void PrintArray1(int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(numbers[i] + "  ");
            }
            //Console.WriteLine("\n");
        }

        void PrintArray2(int[,] numbers)
        {
            int row = numbers.GetLength(0);
            int columns = numbers.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Console.Write($"A[{i}, {j}] = {numbers[i, j]}    ");
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
        }



        //Task54(); //Задача 54
        //Task56(); //Задача 56
        Task58(); //Задача 58
    }
}
