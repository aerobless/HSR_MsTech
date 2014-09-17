using System;

namespace Numbers
{
    internal class ComplexMain
    {
        public static void Main()
        {
            Complex num1 = new Complex(2, 3);
            Complex num2 = new Complex(3, 4);

            // TODO:
            // Erhöhen Sie den Real-Teil von num1 um 2
            num1.Real += 2;


            // TODO: 
            // Bilden Sie die Summe von num1 und num2 
            // und speichern Sie das Resultat in sum.
            // Verwenden Sie die Instanz-Methode Add!
            // Complex sum = ...;
            Complex sum = num1.Add(num2);

            // TODO:
            // Bilden Sie die Summe von num1 und num2 
            // und speichern Sie das Resultat in sum1.
            // Verwenden Sie die statische Methode!
            // Complex sum1 = ...;
            Complex sum1 = Complex.Add(num1, num2);

            // TODO:
            // Bilden Sie die Summe von num1 und num2 
            // und speichern Sie das Resultat in sum2.
            // Verwenden Sie den überladenen Operator +
            // Complex sum2 = ...;
            Complex sum2 = num1 + num2;

            Console.WriteLine("Instanz-Methode:");
            Console.WriteLine("Real: {0}", sum.Real);
            Console.WriteLine("Imaginary: {0}", sum.Imaginary);

            Console.WriteLine("Statische Methode:");
            Console.WriteLine("Real: {0}", sum1.Real);
            Console.WriteLine("Imaginary: {0}", sum1.Imaginary);

            Console.WriteLine("Operator:");
            Console.WriteLine("Real: {0}", sum2.Real);
            Console.WriteLine("Imaginary: {0}", sum2.Imaginary);
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}