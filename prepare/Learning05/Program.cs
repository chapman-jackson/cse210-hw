using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape = new List<Shape>();

        Square c1 = new Square("green",6);
        shape.Add(c1);

        Circle c2 = new Circle("pink",3);
        shape.Add(c2);

        Rectangle c3 = new Rectangle("black",4,12);
        shape.Add(c3);

        foreach (Shape c in shape)
        {
            string color = c.GetColor();

            double area = c.GetArea();

            Console.WriteLine($"The {color} colored shape has the area {area}.");
        }

    }
}