using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Buses b = new Buses();
            b.capacity = 42;
            b.model = "Mercedes";
            //b.Control();
            //b.Motion();

            Ships s = new Ships();
            s.capacity = 200;
            s.model = "Cruise-1";
            s.displacement = 4000;
            //s.Control();
            //s.Motion();
            //s.Scan();

            Planes p0 = new Planes();
            p0.capacity = 180;
            p0.model = "Boeing";
            p0.max_height = 12000;
            //p.Control();
            //p.Motion();
            //p.FindStorm();
                      
            List<Planes> pl = new List<Planes>();
                            
            Planes p1 = new Planes("Airbus", 195, 12100);
            Planes p2 = new Planes("SSJ100", 98, 12200);
            Planes p3 = new Planes("Tupolev", 152, 11100);
            Planes p4 = new Planes("Embraer", 44, 11200);
            Planes p5 = new Planes("AN", 83, 12200);

            pl.AddRange( new Planes[] { p0, p1, p2, p3, p4, p5 });
                 
            Console.WriteLine("Список без сортировки\n");
            foreach (Planes q in pl)
                Console.WriteLine("Модель: {0} Вместимость: {1} Максимальная высота: {2}", q.model, q.capacity, q.max_height);
            Console.WriteLine("\nСписок, отсортированный по вместимости:\n");
            var Plsort = pl.OrderBy(q => q.capacity);
            foreach (Planes q in Plsort)
                Console.WriteLine("Модель: {0} Вместимость: {1} Максимальная высота: {2}", q.model, q.capacity, q.max_height);
        }
    }
}
