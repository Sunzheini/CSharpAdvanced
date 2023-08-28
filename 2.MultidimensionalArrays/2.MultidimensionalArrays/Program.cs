namespace _2.MultidimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[] array1 = new int[3] {1, 2, 3};
            // Console.WriteLine(array1[2]);

            int[][] matrix = new int[3][];      // jagged array
            matrix[0] = new int[2] {1, 2};
            matrix[1] = new int[3] {1, 2, 3};
            matrix[2] = new int[4] {1, 2, 3, 4};
            // Console.WriteLine(matrix[1][2]);        // 3

            int[,] matrix1 = new int[2, 3];
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[0, 2] = 3;
            matrix1[1, 0] = 4;
            matrix1[1, 1] = 5;
            matrix1[1, 2] = 6;
            // Console.WriteLine(matrix1[1, 2]);       // 6
            int[,] matrix2 = new int[3, 4]     // without this its all 0s
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            for (int i = 0; i < matrix2.GetLength(0); i++) { 
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // matrixes use GetLength(0) and GetLength(1) to get the
            // length of the rows and columns!

            // reading a matrix from the console
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix3 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix3[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}