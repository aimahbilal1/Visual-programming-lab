using System;
class Program
{
    static void Main(string[] args)
    {
        int[,,] matrix = new int[3, 3, 3];
        Console.WriteLine("Enter the values for the 3x3x3 Matrix : ");
        for(int i = 0; i<3; i++)
        {
            for(int j = 0; j<3; j++)
            {
                for(int k = 0; k<3; k++)
                {
                    Console.Write($"Enter the value for Matrix[{i},{j},{k}]: ");
                    matrix[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }
        int diagonalsum = 0;
        for (int i = 0;i<3; i++)
        {
            diagonalsum += matrix[i, i, i];
        }
        Console.WriteLine($"The sum of the diagonal element is: {diagonalsum}");
    }
}