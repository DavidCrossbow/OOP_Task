using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Buses b = new Buses();
            b.capacity = 42;
            b.model = "Mercedes";
            b.Control();
            b.Motion();

            Ships s = new Ships();
            s.capacity = 200;
            s.model = "Cruise-1";
            s.displacement = 4000;
            s.Control();
            s.Motion();
            s.Scan();

            Planes p = new Planes();
            p.capacity = 180;
            p.model = "Boeing";
            p.max_height = 12000;
            p.Control();
            p.Motion();
            p.FindStorm();
        }
    }
}
