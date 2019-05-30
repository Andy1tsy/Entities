using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesDefinition
{
    class Box : IBreakableObject
    {
        public int Durability { get => Durability; set => Durability = value; }

        public int CoordX { get => CoordX; private set => CoordX = value; }

        public int CoordY { get => CoordY; private set => CoordY = value; }

        public void Break(int damage)
        {
            if (damage < Durability) { Durability -= damage; return; }
            Durability = 0;
            // delete object  ?? 
        }

        public Box()
        {
            Durability = 10;
            CoordX = 50;
            CoordY = 50;
        }
    }
}
