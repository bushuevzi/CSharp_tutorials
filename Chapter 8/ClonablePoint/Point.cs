using System;

namespace ClonablePoint 
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        //Override Object.ToString()
        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {desc.PetName}; ID = {desc.PointID}";
        }

        //Return a copy of the current object
        public object Clone() => new Point(this.X, this.Y);
    }
}
