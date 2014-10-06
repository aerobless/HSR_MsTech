using System;
using System.Collections.Generic;

public class Math
{
   
}
class Test
{
    public static void Main()
    {
        // Display powers of 2 up to the exponent 8: 
        foreach (int i in Math.Fibonacci(8))
        {
            Console.WriteLine("{0} ", i);
        }

        Console.WriteLine("Press Enter to Exit");
        Console.ReadLine();
    }
}
