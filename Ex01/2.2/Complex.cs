using System;

namespace Numbers
{
    internal struct Complex
    {
        private int real;
        private int imaginary;

        // TODO:
        // Erstellen Sie einen Konstruktor (=Initialisierer) mit 
        // Argumenten für den Real- und Imaginärteil
        public Complex(int real, int imag)
        {
            this.real = real;
            this.imaginary = imag;
        }

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        // TODO:
        // Definieren Sie eine Methode Add, 
        // die eine komplexe Zahl c1 als Argument erhält
        // und als Resultat die Summe von c1 und this liefert
        public Complex Add(Complex c1)
        {
            this.real+=c1.real;
            this.imaginary+=c1.imaginary;
            return this;
        }


        // TODO:
        // Definieren Sie eine statische Methode Add, 
        // die zwei komplexe Zahlen c1 und c2 addiert
        // und die Summer als Resultat liefert		

        public static Complex Add(Complex c1, Complex c2)
        {
            int imag = c1.Imaginary + c2.Imaginary;
            int real = c1.real + c2.real;

            return new Complex(real, imag);
        }

        // TODO:
        // Ueberladen Sie den Operator + so, dass die Operation
        // Complex c = c1 + c2 formuliert werden kann.
        // Tip: Verwenden Sie die statische Methode Add

        public static Complex operator+(Complex c1, Complex c2){
            return Add(c1, c2);
        }
    }
}