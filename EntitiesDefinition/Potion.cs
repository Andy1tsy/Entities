using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    class Potion : ICargo
    {
        public int Weight { get => Weight; private set => Weight = value; }

        public int CoordX { get => CoordX; private set => CoordX = value; }

        public int CoordY { get => CoordY; private set => CoordY = value; }

        public void Efeect()
        {
            // Some effect
        }

        public Potion()
        {
            Weight = 10;
            CoordX = 50;
            CoordY = 50;
        }
    }
}
