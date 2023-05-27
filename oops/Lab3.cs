//12.Створити інтерфейс, що містить опис методів для роботи з двовимірними векторами
//    (знаходження довжини вектора, суми векторів, множення вектора на число, скалярного добутку)
//    та класи, які містять реалізації методів інтерфейсу у випадку, коли вектор задано
//його координатами та координатами початку і кінця.

using System;
namespace oops
{
    public class Lab3
    {
        public Lab3()
        {
        }


        public void execute() {
            IVector2D vector1= new Vector2D(5,4,7,9);
            Vector2D vector2 = new Vector2D(8, 4, 3, 8);
            Console.WriteLine("Lenght of vector 1");
            double lenght1 = vector1.Length();
            Console.WriteLine(lenght1.ToString());
            Console.WriteLine("Lenght of vector 2");
            double lenght2 = vector2.Length();
            Console.WriteLine(lenght2.ToString());
            IVector2D vector3 = vector1.Add(vector2);
            double lenght3 = vector3.Length();
            Console.WriteLine("Lenght of vector 3");
            Console.WriteLine(lenght3.ToString());





        }
    }
}


interface IVector2D
{
    double Length();
    Vector2D Add(Vector2D vector);
    Vector2D Multiply(double scalar);
    double Dot(Vector2D vector);
}

class Vector2D : IVector2D
{
    private double x1, y1, x2, y2;

    public Vector2D(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public double Length()
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public Vector2D Add(Vector2D vector)
    {
        double newX2 = x2 + vector.x2 - vector.x1;
        double newY2 = y2 + vector.y2 - vector.y1;
        return new Vector2D(x1, y1, newX2, newY2);
    }

    public Vector2D Multiply(double scalar)
    {
        double newX2 = x1 + (x2 - x1) * scalar;
        double newY2 = y1 + (y2 - y1) * scalar;
        return new Vector2D(x1, y1, newX2, newY2);
    }

    public double Dot(Vector2D vector)
    {
        double thisX = x2 - x1;
        double thisY = y2 - y1;
        double vectorX = vector.x2 - vector.x1;
        double vectorY = vector.y2 - vector.y1;
        return thisX * vectorX + thisY * vectorY;
    }
}
