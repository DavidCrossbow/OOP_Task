using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Planes : TransportVehicle, Meteo
    {
        public int max_height; // объявление поля "максимальная высота"
        public override void Control() // Имплементация управления самолётом
        {
            throw new NotImplementedException();
        }

        public void FindStorm() // Имплементация режима "Метео". Поиск гроз
        {
            throw new NotImplementedException();
        }

        public override void Motion() // Имплементация движения самолёта
        {
            throw new NotImplementedException();
        }

        public void Scan() // Имплементация амолётного радара
        {
            throw new NotImplementedException();
        }
    }
}
