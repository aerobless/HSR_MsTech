using System;
using System.IO;

// TODO:
// Delegate f�r "LogWriter" erstellen
// delegate void ...


public class Test
{
    // TODO:
    // Klassenvariable vom Typ "LogWriter" erstellen
    // private static ...

    // TODO:
    // Methode "Print" f�r Ausgabe auf dem Bildschirm erstellen
    // private static void ...

    public static void Main(string[] arg)
    {
        // TODO:
        // Logger Instanz erstellen
        // Logger logger = ...

        // TODO:
        // Event f�r Ausgabe auf dem Bildschirm anmelden
        // Log += ... 

        // TODO:
        // Event f�r Ausgabe in File anmelden
        // Log += ... 

        // TODO:
        // Logeintr�ge erstellen
        // ...
        // ...
        // ...

        // TODO:
        // Buffer der "Logger" Instanz schreiben und danach schliessen
        // logger.? ...
        // logger.? ...

        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
    }

    public class Logger
    {
        // TODO:
        // StreamWriter-Variable (System.IO)
        // private  ...

        // TODO:
        // Konstruktor mit Dateipfad
        // public Logger ...

        // TODO:
        // Methode "Print" f�r Ausgabe in eine Datei erstellen
        // public void ...

        // TODO:
        // Methode "Flush"
        // public void ...

        // TODO:
        // Methode "Close"
        // public void ...
    }
}