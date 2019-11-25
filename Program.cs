using System;

namespace virutalandoverrideexample
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 6.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape cy = new Cylinder(r, h);
            Console.WriteLine($"Area of Circle = {c.Area()}");
            Console.WriteLine($"Area of Sphere = {s.Area()}");
            Console.WriteLine($"Area of Cylinder = {cy.Area()}");
        }
    }
}
