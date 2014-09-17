using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square: Polygon
    {
        private float x1, y1; //Koordinaten obere Ecke
        private float len;
        private const ushort numSide = 4;

        public Square(float x1, float y1, float len)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.len = len;
        }

        public float X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public float Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public float X2
        {
            get { return x1 + 4; }
        }

        public float Y2
        {
            get { return y1 + 4; }
        }

        public override ushort NumSides
        {
            get { return numSide; }
        }

        public override float Area()
        {
            return len * len;
        }
    }
}
