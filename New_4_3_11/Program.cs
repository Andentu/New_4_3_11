namespace New_4_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 4, 6, 1, 0, 22 }, { 4, 33, 21, 1, 0 }, { 65, 1, 0, -2, 5 }, { 1, 0, 66, -87, 39 }, { 38, 0, 41, -23, -1 } };
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}