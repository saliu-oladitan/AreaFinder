using System;

namespace GeometricTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 2 }; // We will instantiate the width
            var triangle = new Triangle() { Base = 2, Height = 5 };

            square.Display();  //USe the dispaly function in the abstract class but just go and look for the definition of GetArea() in the Square class.
            triangle.Display();
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();
        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }
    class Square : Shape
    {
        public int Width;
        public override int GetArea() //Append the keyword override to this line
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;
        public override int GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}
