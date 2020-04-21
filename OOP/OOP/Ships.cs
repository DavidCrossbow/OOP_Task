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
    }
}
