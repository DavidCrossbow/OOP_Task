using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Buses : TransportVehicle, Radar
    {
        public override void Control()
        {
            throw new NotImplementedException(); //Имплементация управления автобусом
        }

        public override void Motion() // //Имплементация движения автобуса
        {
            throw new NotImplementedException();
        }
    }
}
