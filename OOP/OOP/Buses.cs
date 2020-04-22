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
        public Buses() { } // Пустой конструктор
        public Buses(string model, int capacity) //Параметризированный конструктор
        {
            this.model = model;
            this.capacity = capacity;
        }
    }
}
