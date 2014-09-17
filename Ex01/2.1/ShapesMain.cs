using System;

namespace Shapes
{
    public class ShapesMain
    {
        public static void Main()
        {
            // TODO:
            // Erzeuge Square-Objekt
            Square myFirstSquare = new Square(1,2,4);
            // Ausgabe Degrees
            Console.WriteLine("Degrees: "+myFirstSquare.Degrees);
            // Ausgabe Area
            Console.WriteLine("Area: " + myFirstSquare.Area());
            // Ausgabe x1, y1, x2, y2
            Console.WriteLine("X1:" + myFirstSquare.X1+" Y1:"+myFirstSquare.Y1+" X2:"+myFirstSquare.X2+" Y2:"+myFirstSquare.Y2);
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}
