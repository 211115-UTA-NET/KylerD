using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Square NewSquare;
            NewSquare = new Square("Square", 4, 3, 3);
            NewSquare.GetInfo();
            NewSquare.GetArea();


            Rectangle NewRectangle;
            NewRectangle = new Rectangle("Rectangle", 4, 5, 7);
            NewRectangle.GetInfo();
            NewRectangle.GetArea();

            Triangle NewTriangle;
            NewTriangle = new Triangle("Triangle", 3, 4, 5, 6);
            NewRectangle.GetInfo();
            NewTriangle.GetArea();
        }
    }
}
