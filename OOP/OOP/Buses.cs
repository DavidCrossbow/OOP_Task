using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Buses : TransportVehicle
    {
        public override void Control() //Имплементация управления автобусом
        {
            throw new NotImplementedException(); 
        }

        public override void Motion() //Имплементация движения автобуса
        {
            throw new NotImplementedException();
        }
        public Buses()
        {  
            Console.WriteLine("Введите модель автобуса:");
            model = Console.ReadLine();
            Console.WriteLine("Введите вместимость:");
           
            try
            {
                capacity = int.Parse(Console.ReadLine());
                if ((capacity < 10)||(capacity > 60))
                {
                    capacity = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch(FormatException e1)
            {
                Program.newlog.Warn("Попытка записи недопустимых символов. {0}", e1.Message);
            }
            catch (ArgumentOutOfRangeException e2)
            {
                Program.newlog.Warn("Вместимость должна быть в диапазоне [10, 60]! {0}", e2.Message);
            }
        } 
        public Buses(string model, int capacity) //Параметризированный конструктор
        {
            this.model = model;
            this.capacity = capacity;
        }
    }
}
