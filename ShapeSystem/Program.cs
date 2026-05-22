using ShapeSystem.Models;

namespace ShapeSystem;

public class Program
{
    public static void Main(string[] args)
    {
        Shape shape = new Shape();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();

        shape.Draw();
        circle.Draw();
        rectangle.Draw();
        triangle.Draw();
    }
}