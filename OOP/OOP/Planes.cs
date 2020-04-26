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

        public void Scan() // Имплементация самолётного радара
        {
            throw new NotImplementedException();
        }
        public Planes() { } // Пустой конструктор
        public Planes(string model, int capacity, int max_height) // Параметризированный конструктор
        {
            this.model = model;
            this.capacity = capacity;
            this.max_height = max_height;
        }
    }
}
