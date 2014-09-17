using System;
using System.Collections.Generic;

namespace Polymorphism
{

    interface IGObject
    {

    }

    class GObject : IGObject
    {
        protected string name;

        protected GObject(string name)
        {
            this.name = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine("GObject: {0}", name);
        }
        
        public void WhoAreYou()
        {
            Console.WriteLine("GObject: {0}", name);
        }
    }

    class Kreis : GObject
    {
        public Kreis(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Kreis: {0}", name);
        }
        
        public new void WhoAreYou()
        {
            Console.WriteLine("Kreis: {0}", name);
        }
    }

    class Rechteck : GObject
    {
        public Rechteck(string name) : base(name) { }
    
        public override void Draw()
        {
            Console.WriteLine("Rechteck: {0}", name);
        }
      
        public new void WhoAreYou()
        {
            Console.WriteLine("Rechteck: {0}", name);
        }
    }

    class Compound : GObject
    {
        List<GObject> objList = new List<GObject>();

        public Compound(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Compound: {0}", name);
            foreach (GObject g in objList)
            {
                g.Draw();
            }
            Console.WriteLine("End Compound: {0}", name);
        }

        public new void WhoAreYou()
        {
            Console.WriteLine("Compound: {0}", name);
            foreach (GObject g in objList)
            {
                g.WhoAreYou();
            }
            Console.WriteLine("End Compound: {0}", name);
        }

        public void Add(GObject g)
        {
            objList.Add(g);
        }
    }

    class Test
    {
        static void Main()
        {
            Compound g = new Compound("C1");
            g.Add(new Kreis("K1"));

            Compound g1 = new Compound("C2");
            g1.Add(new Rechteck("R21"));
            g1.Add(new Kreis("K21"));
            g.Add(g1);
            g.Add(new Kreis("K2"));

            Console.WriteLine("Drawing ... (dynamic binding)");
            g.Draw();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            Console.WriteLine("calling \"who are you\" (static binding)");
            g.WhoAreYou();
            Console.ReadLine();
            Console.WriteLine("press enter to continue");
        }
    }
}
