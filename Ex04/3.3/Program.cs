using System;
using System.Linq;
using System.Text;
using System.IO;

namespace Textanalyse
{
    class Program
    {
        static void AnalysiereText(string text)
        {
            var wortListe = text.Split(new[] { " ", "\n", ",", "{", "}" }, StringSplitOptions.RemoveEmptyEntries);

            /* 
             * to do
            */
        }

        static void Main(string[] args)
        {
            StringBuilder inbuffer = new StringBuilder();

            Console.WriteLine("Lade source file Programm.cs");
            using (StreamReader sr = File.OpenText(@"..\..\test.txt"))
            {
                String input;
                while ((input = sr.ReadLine()) != null)
                {
                    inbuffer.Append(input);
                }
                sr.Close();
            }
            AnalysiereText(inbuffer.ToString());

            //foreach (var p in res.OrderBy(c => c.Value))
            //    Console.WriteLine("Wort: {0}, Anzahl: {1}", p.Key, p.Value);
            Console.ReadLine();
        }
    }
}
