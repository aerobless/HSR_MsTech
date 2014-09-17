using System;

namespace Shapes
{
    public abstract class Polygon
    {
        public abstract ushort NumSides { get; }
        public int Degrees
        {
            get
            {
                return (NumSides - 2) * 180;
            }
        }
        public abstract float Area();
    }
}
