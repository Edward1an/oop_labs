using System;
namespace oops
{
    public class Lab1
    {

        public void execute()
        {
            Console.WriteLine("Hello, World in Labd!");

            TMatrix matrix = new TMatrix();
            matrix.Input();
            matrix.Output();
        }
    }
}
class TMatrix
{
    private int[,] elements;
    private int rows;
    private int columns;

    public TMatrix()
    {
        rows = 0;
        columns = 0;
        elements = null;
    }

    public TMatrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        elements = new int[rows, columns];
    }

    public TMatrix(TMatrix matrix)
    {
        rows = matrix.rows;
        columns = matrix.columns;
        elements = (int[,])matrix.elements.Clone();
    }

    public void Input()
    {
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element[{0},{1}]: ", i, j);
                elements[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void Output()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0}\t", elements[i, j]);
            }
            Console.WriteLine();
        }
    }

    public int Max()
    {
        int max = elements[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (elements[i, j] > max)
                {
                    max = elements[i, j];
                }
            }
        }
        return max;
    }

    public int Min()
    {
        int min = elements[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (elements[i, j] < min)
                {
                    min = elements[i, j];
                }
            }
        }
        return min;
    }

    public int Sum()
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += elements[i, j];
            }
        }
        return sum;
    }

    public static TMatrix operator +(TMatrix matrix1, TMatrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
        {
            throw new Exception("Matrices must be of the same size.");
        }

        TMatrix result = new TMatrix(matrix1.rows, matrix1.columns);
        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.columns; j++)
            {
                result.elements[i, j] = matrix1.elements[i, j] + matrix2.elements[i, j];
            }
        }
        return result;
    }

    public static TMatrix operator -(TMatrix matrix1, TMatrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
        {
            throw new Exception("Matrices must be of the same size.");
        }

        TMatrix result = new TMatrix(matrix1.rows, matrix1.columns);
        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.columns; j++)
            {
                result.elements[i, j] = matrix1.elements[i, j] - matrix2.elements[i, j];
            }
        }
        return result;
    }
}
