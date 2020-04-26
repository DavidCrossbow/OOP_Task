using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        public static Logger newlog = LogManager.GetCurrentClassLogger();
        [Meta (firstname = "Gleb", lastname = "Suslo")]
        static void Main(string[] args)
        {
            List<Buses> sh = new List<Buses>();
            Buses b1 = new Buses();
            Buses b2 = new Buses();

            sh.Add(b1);
            sh.Add(b2);

            Console.WriteLine("\nСписок Автобусов\n");
            foreach (Buses q in sh)
                Console.WriteLine("Модель: {0} Вместимость: {1}\n", q.model, q.capacity);
            newlog.Info("Cписок автобусов сформирован");
        }
    }
}
