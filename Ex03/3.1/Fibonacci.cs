using System.Collections.Generic;
using System;

public class Math2
{

    public static IEnumerable<int> Fibonacci(int lastNumber)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < lastNumber; i++)
        {
            if (i == 0)
            {
                yield return 0;
            }

            int temp = a;
            a = b;
            b = temp + b;
            yield return a;
        }
    }
   
}
class Test
{
    public static void Main()
    {
        // Display powers of 2 up to the exponent 8: 
        foreach (int i in Math2.Fibonacci(30))
        {
            System.Console.WriteLine("{0} ", i);
        }

        System.Console.WriteLine("Press Enter to Exit");
        System.Console.ReadLine();
    }
}
