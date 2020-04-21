using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface Meteo: Radar
    {
        void FindStorm(); // Поиск грозовых фронтов
    }
}
