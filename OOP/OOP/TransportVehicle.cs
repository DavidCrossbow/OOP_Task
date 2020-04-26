using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class TransportVehicle // Абстрактный класс "Транспортные средства"
    {
        public string model; // Модель
        public int capacity; // Вместимость
        
        public abstract void Control (); // Управление
        public abstract void Motion(); // Движение
    }
}
