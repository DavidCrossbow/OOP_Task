using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Ships : TransportVehicle, Radar
    {
        public int displacement; // Объявление поля "водоизмещение" 
        public override void Control() //Имплементация управления кораблём
        {
            throw new NotImplementedException();
        }

        public override void Motion() //Имплементация движения корабля
        {
            throw new NotImplementedException();
        }

        public void Scan() //Имплементация работы корабельного радара
        {
            throw new NotImplementedException();
        }
        public Ships() {} // Пустой конструктор
        public Ships(string model, int capacity, int displacement) // Параметризированный конструктор
        {
            this.model = model;
            this.capacity = capacity;
            this.displacement = displacement;
        }

    }
}
