using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        protected int length {get; set;} = 0;
        protected int width {get; set;} = 0;

        public Rectangle(string Name, int NumSides, int length, int width) : base (Name, NumSides)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.length = length;
            this.width = width;
        }

        protected override void SetArea()
        {
            Area = width * length;
        }
        public override double MyArea
        {
            get
            {
                return Area;
            }
        }
    }
}
