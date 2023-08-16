using System;
namespace ShapeHierarchy
{
    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Circle Details:");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            // Using Heron's formula to calculate the area of a triangle
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Triangle Details:");
            Console.WriteLine($"Side 1: {Side1}");
            Console.WriteLine($"Side 2: {Side2}");
            Console.WriteLine($"Side 3: {Side3}");
            Console.WriteLine($"Area: {CalculateArea()}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(3, 4, 5);

            circle.DisplayDetails();
            Console.WriteLine();
            rectangle.DisplayDetails();
            Console.WriteLine();
            triangle.DisplayDetails();

            Console.ReadLine();
        }
    }

}