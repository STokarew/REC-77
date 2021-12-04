using System;

namespace REC_77
{
    class Program
    {
        private static int[,] RandomMatrix(int[,] ARR)
        {
            Random rnd = new Random();
            for (int i = 0; i < ARR.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < ARR.GetLength(1) - 1; j++)
                {
                    ARR[i, j] = rnd.Next(10, 100); 
                }
            }
            return ARR;
        }
        static void PrintMatrix(int[,] Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            var Row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            var Column = int.Parse(Console.ReadLine());
            int[,] Arr = new int[Row, Column];
            PrintMatrix(RandomMatrix(Arr));
            Console.ReadKey();
        }
    }
}
