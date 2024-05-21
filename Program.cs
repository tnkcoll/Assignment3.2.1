namespace Assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = Create2DArray();
            Print2DArray(numbers);
        }

        public static int[,] Create2DArray()
        {
            int[,] nums = { { 2, 3, 4 }, { 1, 4, 6 } };
            return nums;
        }

        public static void Print2DArray(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                Console.Write("|");
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write($"{nums[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
