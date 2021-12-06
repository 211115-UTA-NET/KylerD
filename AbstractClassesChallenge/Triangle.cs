using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        protected int side1 {get; set;} = 0;
        protected int side2 {get; set;} = 0;
        protected int side3 {get; set;} = 0;

        protected int semi = 0;
            public Triangle(string Name, int NumSides, int side1, int side2, int side3) : base (Name, NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
        }

        protected override void SetArea()
        {
            semi = (side1 + side2 + side3) / 2;
            area = Math.Sqrt(semi * (semi - side1) * (semi - side2) * (semi - side3));
        }
        public override double MyArea
        {
            get
            {
                return area;
            }
        }
            // HINT: Use Herons Formula to calculate and set the area.
    }
}
