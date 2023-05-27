using System;
namespace oops
{
    public class Lab2
    {
        public void execute()
        {
            Console.WriteLine("Choose task");
            int labNumber = int.Parse(Console.ReadLine());
            switch (labNumber)
            {
                case 1:

                    break;
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }

        }
        public void execute1()
        {
            {
                Console.WriteLine("Введіть розмірність векторів:");
                int n = int.Parse(Console.ReadLine());

                double[] x = new double[n];
                double[] y = new double[n];

                Console.WriteLine("Введіть координати вектора x:");
                for (int i = 0; i < n; i++)
                {
                    x[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введіть координати вектора y:");
                for (int i = 0; i < n; i++)
                {
                    y[i] = double.Parse(Console.ReadLine());
                }

                int count_x = 0;
                int count_y = 0;

                for (int i = 0; i < n; i++)
                {
                    if (x[i] > 0)
                    {
                        count_x++;
                    }

                    if (y[i] > 0)
                    {
                        count_y++;
                    }
                }

                double[] z = new double[count_x + count_y];
                int index = 0;

                for (int i = 0; i < n; i++)
                {
                    if (x[i] > 0)
                    {
                        z[index] = x[i];
                        index++;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    if (y[i] > 0)
                    {
                        z[index] = y[i];
                        index++;
                    }
                }

                Console.Write("Вектор z: [ ");
                for (int i = 0; i < count_x + count_y; i++)
                {
                    Console.Write(z[i] + " ");
                }
                Console.WriteLine("]");
            }

        }
        public void execute2() { }

        public void execute3()
        {
            {
                Console.WriteLine("Введіть розмірність масиву:");
                int n = int.Parse(Console.ReadLine());

                double[] arr = new double[n];

                Console.WriteLine("Введіть елементи масиву:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введіть інтервал [a, b]:");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double temp;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Floor(arr[i]) < Math.Floor(arr[j]))
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

                Console.Write("Масив після перетворення: [ ");
                for (int i = 0; i < n; i++)
                {
                    if (Math.Floor(arr[i]) >= a && Math.Floor(arr[i]) <= b)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (Math.Floor(arr[i]) < a || Math.Floor(arr[i]) > b)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                Console.WriteLine("]");
            }
        }

        public void execute4()
        {
            {
                Console.WriteLine("Введіть розмірність матриці:");
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());

                int[,] matrix = new int[n, m];

                Console.WriteLine("Введіть елементи матриці:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Введіть кількість позицій k:");
                int k = int.Parse(Console.ReadLine());

                // циклічний зсув парних стовпців матриці
                for (int j = 0; j < m; j += 2)
                {
                    int[] temp = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        temp[(i + k) % n] = matrix[i, j];
                    }
                    for (int i = 0; i < n; i++)
                    {
                        matrix[i, j] = temp[i];
                    }
                }

                Console.WriteLine("Матриця після зсуву:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void execute5() { }
        public void execute6() { }

    }
}