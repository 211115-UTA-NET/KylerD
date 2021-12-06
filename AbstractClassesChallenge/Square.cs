using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        public Square(string Name, int NumSides, int length, int width) : base (Name, NumSides, length, width)
        {
            this.Name = Name;
            this.NumSides = NumSides;
            this.length = length;
            this.width = width;
        }

        protected override void SetArea()
        {
            area = length ^ 2;
        }
        public override double MyArea
        {
            get
            {
                return area;
            }
        }
    }
}
