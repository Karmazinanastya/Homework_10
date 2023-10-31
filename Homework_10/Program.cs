using System;
using System.Collections.Generic;
using System.Linq;

namespace Triangle
{
    public struct Point
    {
        public double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public double Distance(Point other)
        {
            double deltaX = x - other.x;
            double deltaY = y - other.y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    public class Triangle
    {
        public Point vertex1, vertex2, vertex3;

        public Triangle(Point v1, Point v2, Point v3)
        {
            vertex1 = v1;
            vertex2 = v2;
            vertex3 = v3;
        }

        public double Distance(Point p1, Point p2)
        {
            return p1.Distance(p2);
        }

        public double Perimeter()
        {
            return Distance(vertex1, vertex2) + Distance(vertex2, vertex3) + Distance(vertex3, vertex1);
        }

        public double Square()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);
            double s = Perimeter() / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertices: {vertex1}, {vertex2}, {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter():F2}");
            Console.WriteLine($"Square: {Square():F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Triangle> triangles = new List<Triangle>
        {
            new Triangle(new Point(1, 2), new Point(3, 4), new Point(5, 6)),
            new Triangle(new Point(0, 0), new Point(1, 1), new Point(2, 2)),
            new Triangle(new Point(3, 3), new Point(4, 4), new Point(5, 5))
        };


            Triangle closestToOrigin = triangles.OrderBy(t =>
            {
                double minDistance = Math.Min(
                    t.vertex1.Distance(new Point(0, 0)),
                    Math.Min(t.vertex2.Distance(new Point(0, 0)), t.vertex3.Distance(new Point(0, 0)))
                );
                return minDistance;
            }).First();

            Console.WriteLine("Triangles Information:");
            foreach (var triangle in triangles)
            {
                triangle.Print();
                Console.WriteLine();
            }

            Console.WriteLine("Triangle closest to the origin:");
            closestToOrigin.Print();
        }
    }
}